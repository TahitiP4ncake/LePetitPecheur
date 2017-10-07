using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour {

    //public GameObject pecheur;

	private Vector2 lastPosition;

    private List<string> messages = new List<string>();

    

    DateTime lastDate;

    DateTime lastOpening;


	// Use this for initialization
	void Start () {

		Application.runInBackground = true;

        messages = CSVReader.Read("Messages");

        GetLastDate();

        PlayerPrefs.Save();

        DeterminePossibility();

    }

    void GetLastDate()
    {
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

    }

    TimeSpan CalculInterval(DateTime _old, DateTime _now)
    {
        TimeSpan _ts = _now - _old;
        return _ts;
    }

    void DeterminePossibility()
    {
        CalculInterval(lastDate, DateTime.Now);


    }






    void OnApplicationQuit()
    {
        SaveDayTime();
    }

    void SaveDayTime()
    {
        PlayerPrefs.SetInt("Year", DateTime.Now.Year);
        PlayerPrefs.SetInt("Month", DateTime.Now.Month);
        PlayerPrefs.SetInt("Day", DateTime.Now.Day);
        PlayerPrefs.SetInt("Hours", DateTime.Now.Hour);
        PlayerPrefs.SetInt("Minutes", DateTime.Now.Minute);
        PlayerPrefs.SetInt("Secondes", DateTime.Now.Second);
    }
}
