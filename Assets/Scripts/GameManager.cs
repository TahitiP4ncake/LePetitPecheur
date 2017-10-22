using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour {

    //public GameObject pecheur;

	private Vector2 lastPosition;

    private List<string> messages = new List<string>();

    private List<string> randomMessages = new List<string>();

    DateTime lastDate;

    DateTime lastOpening;

    DateTime timerMessage;

    DateTime timerObject;

    bool canHaveMessage = false;
    bool canHaveObject = false;

    int dayBeforeMessage = 1;
    int minutesBeforeObject;

    bool isBusy = false;

    int nrbOfMessages;



	// Use this for initialization
	void Start () {

		Application.runInBackground = true;

        messages = CSVReader.Read("Messages");

        GetSavedData();

        PlayerPrefs.Save();

        if (canHaveMessage == false)
        {
            DeterminePossibility();
        }

        StartCoroutine(TimePassed());

        minutesBeforeObject = UnityEngine.Random.Range(20, 31);

    }

    void GetSavedData()
    {
        // Messages
        int _nbrMessages = PlayerPrefs.GetInt("NbrMessages", 0);

        for (int i = 0; i < _nbrMessages; i++)
        {
            randomMessages.Add(PlayerPrefs.GetString("Message" + i));
        }

        // Date

        int _year = PlayerPrefs.GetInt("Year", -1);

        if(_year == -1)
        {
            lastDate = DateTime.Now;
            return;
        }

        int _month = PlayerPrefs.GetInt("Month", -1);
        int _day = PlayerPrefs.GetInt("Day", -1);
        int _hours = PlayerPrefs.GetInt("Hours", -1);
        int _minutes = PlayerPrefs.GetInt("Minutes", -1);
        int _secondes = PlayerPrefs.GetInt("Secondes", -1);

        lastDate = new DateTime();
        lastDate = lastDate.AddYears(_year-1);
        lastDate = lastDate.AddMonths(_month-1);
        lastDate = lastDate.AddDays(_day-1);
        lastDate = lastDate.AddHours(_hours);
        lastDate = lastDate.AddMinutes(_minutes);
        lastDate = lastDate.AddSeconds(_secondes);

        // Fishing Time
        int _ft = PlayerPrefs.GetInt("TimerMessage", 0);
        timerMessage.AddMinutes(_ft);

        _ft = PlayerPrefs.GetInt("TimerObject", 0);
        timerObject.AddMinutes(_ft);


        // Can have

        int _intToBool;
        _intToBool = PlayerPrefs.GetInt("CanHaveObject", 0);

        if(_intToBool==0)
        {
            canHaveMessage = false;
        }
        else
        {
            canHaveMessage = true;
        }

        _intToBool = PlayerPrefs.GetInt("CanHaveObject", 0);

        if (_intToBool == 0)
        {
            canHaveObject = false;
        }
        else
        {
            canHaveObject = true;
        }

    }

    void DeterminePossibility()
    {
        TimeSpan _ts = DateTime.Now - lastDate;

        if(_ts.TotalDays >1)
        {
            canHaveMessage = true;
        }
    }

    IEnumerator TimePassed()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            timerMessage.AddSeconds(1);
            timerObject.AddSeconds(1);
            
            if(timerMessage.Day>= dayBeforeMessage)
            {
                timerMessage = new DateTime();
                canHaveMessage = true;
            }

            if(timerObject.Minute>= minutesBeforeObject)
            {
                timerObject = new DateTime();
                canHaveObject = true;
            }


            if (isBusy == false)
            {
                if (canHaveMessage)
                {
                    isBusy = true;
                }

                if (canHaveObject)
                {
                    isBusy = true;
                }
            }
        }
    }

    void GetNewMessage()
    {

    }

    void GetNewObject()
    {

    }

    void OnApplicationQuit()
    {
        SaveData();
    }

    void SaveData()
    {
        // Last date
        PlayerPrefs.SetInt("Year", DateTime.Now.Year);
        PlayerPrefs.SetInt("Month", DateTime.Now.Month);
        PlayerPrefs.SetInt("Day", DateTime.Now.Day);
        PlayerPrefs.SetInt("Hours", DateTime.Now.Hour);
        PlayerPrefs.SetInt("Minutes", DateTime.Now.Minute);
        PlayerPrefs.SetInt("Secondes", DateTime.Now.Second);

        // Timer fishing
        TimeSpan _ts; 
        _ts = timerMessage.TimeOfDay;
        PlayerPrefs.SetInt("TimerMessage", (int)_ts.TotalMinutes);
        _ts = timerObject.TimeOfDay;
        PlayerPrefs.SetInt("TimerObject", (int)_ts.TotalMinutes);

        // Can Have
        if (canHaveMessage)
        {
            PlayerPrefs.SetInt("CanHaveMessage", 1);
        }
        else
        {
            PlayerPrefs.SetInt("CanHaveMessage", 0);
        }

        if (canHaveObject)
        {
            PlayerPrefs.SetInt("CanHaveObject", 1);
        }
        else
        {
            PlayerPrefs.SetInt("anHaveObject", 0);
        }

        // Messages
        /*
        for (int i = 0; i < TotalInventoryItem; i++)
        {
            PlayerPrefs.SetString("InventoryItem" + i, "*insert your item value or name*");
        }
        */
    }
}
