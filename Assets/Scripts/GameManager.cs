using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour {

    public FishermanAnimator fisherAnimator;

    //public GameObject pecheur;

	private Vector2 lastPosition;

<<<<<<< HEAD
    private List<string> allMessages = new List<string>();

    private List<string> randomMessages = new List<string>();
=======
    // All the messages in the .CSV
    public List<string> allMessages = new List<string>();

    // List of all messages not displayed yet, randomized
    public List<string> randomMessages = new List<string>();
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5

    DateTime lastDate;

    DateTime lastOpening;

<<<<<<< HEAD
    DateTime timerMessage;

    DateTime timerObject;

    bool canHaveMessage = false;
    bool canHaveObject = false;

    int dayBeforeMessage = 1;
    int minutesBeforeObject;

    bool isBusy = false;

    int nbrOfMessages;


=======
    int timerObject;
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5

    int timerMessage;


    bool canHaveMessage = false;
    bool canHaveObject = false;

    const int dayBeforeMessage = 1;

    int minutesBeforeObject=20;

    bool isBusy = false;

    // Memory of the maximum of all messages
    int nbrOfMessages;

    //DEBUG
    bool canHaveAMessage = false;

	// Use this for initialization
	void Start ()
    {
        // System settings
		Application.runInBackground = true;

<<<<<<< HEAD
        allMessages = CSVReader.Read("Messages");

        GetSavedData();

        if(allMessages.Count != nbrOfMessages)
        {
            ActualizeMessagesList();
        }
=======
        // Get all the messages from the .CSV
        allMessages = CSVReader.Read("Messages");

        // Get all the old data
        GetSavedData();
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5

        // If the .CSV change since the last time (aka new messages)
        if(allMessages.Count != nbrOfMessages)
        {
            ActualizeMessagesList();
        }

        // Save the actual settings
        PlayerPrefs.Save();

<<<<<<< HEAD
        if (canHaveMessage == false)
        {
            DeterminePossibility();
        }

        StartCoroutine(TimePassed());

        minutesBeforeObject = UnityEngine.Random.Range(20, 31);
=======
        // If the player can't have new message the last time, determinePossibilities to show the time spend out of the game
        if (canHaveMessage == false)
        {
            //DeterminePossibilities();
        }

        if (randomMessages.Count == 0)
        {
            ResetMessages(allMessages);
        }
        
        // Start to count the time passed
        StartCoroutine(TimePassed());

        // Define minutes before new objects
        minutesBeforeObject = UnityEngine.Random.Range(20,32);
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5

    }

    void GetSavedData()
    {
        // Messages
<<<<<<< HEAD
        int _nbrMessages = PlayerPrefs.GetInt("NbrMessages", 0);

        for (int i = 0; i < _nbrMessages; i++)
=======
        int _nbrRandomMessages = PlayerPrefs.GetInt("RandomMessages", 0);

        for (int i = 0; i < _nbrRandomMessages; i++)
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5
        {
            randomMessages.Add(PlayerPrefs.GetString("RandomMessages" + i));
        }

<<<<<<< HEAD
=======
        nbrOfMessages = PlayerPrefs.GetInt("NbrMessages", 0);

>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5
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
<<<<<<< HEAD
        int _ft = PlayerPrefs.GetInt("TimerMessage", 0);
        timerMessage.AddMinutes(_ft);

        _ft = PlayerPrefs.GetInt("TimerObject", 0);
        timerObject.AddMinutes(_ft);


        // Can have

        int _intToBool;
        _intToBool = PlayerPrefs.GetInt("CanHaveObject", 0);
=======
        int memoryValue = PlayerPrefs.GetInt("TimerMessage", 0);
        timerMessage += memoryValue;

        memoryValue = PlayerPrefs.GetInt("TimerObject", 0);
        timerObject += memoryValue;


        // Can have a new message?

        int _intToBool;
        _intToBool = PlayerPrefs.GetInt("CanHaveMessage", 0);
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5

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

<<<<<<< HEAD
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

                    GetNewMessage();
                }

                if (canHaveObject)
                {
                    isBusy = true;

                    GetNewObject();
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

    void ActualizeMessagesList()
    {
        if (allMessages.Count < nbrOfMessages)
        {
            ResetMessages();
        }
        else
        if (allMessages.Count > nbrOfMessages)
        {
            // Add new messages to the possibilities

            List<string> _newMessages = new List<string>();

            for(int i = nbrOfMessages+1; i<allMessages.Count; i++)
            {
                _newMessages.Add(allMessages[i]);
            }

        }

        nbrOfMessages = randomMessages.Count;

    }

    // Fill the randomMessages with the message list, randomize
    void ResetMessages()
    {
        randomMessages = new List<string>();

        List<String> _temporaryList = new List<string>();

        foreach(String _string in allMessages)
        {
            _temporaryList.Add(_string);
        }

        int _index;

        for(int i = 0; i< _temporaryList.Count; i++)
        {
            _index = UnityEngine.Random.Range(0, _temporaryList.Count + 1);

            randomMessages.Add(_temporaryList[_index]);

=======
    }

    void DeterminePossibilities()
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

            if (isBusy)
            {
                continue;
            }

            if (canHaveAMessage == false)
            {
                timerMessage++;

                if (CanHaveMessage(timerMessage))
                {
                    timerMessage = 0;
                    canHaveMessage = true;
                }

            }

            if (canHaveObject == false)
            {
                timerObject++;

                if (CanHaveObject(timerObject))
                {
                    timerObject = 0;
                    canHaveObject = true;
                }

            }

            if (canHaveMessage)
            {
                canHaveMessage = false;

                isBusy = true;

                SendNewMessage();
            }

            if (canHaveObject)
            {
                canHaveObject = false;

                isBusy = true;

                GetNewObject();
            }

        }
    }

    void SendNewMessage()
    {
        // Send new message and play the animation
        fisherAnimator.PlayAnimation(AnimationState.Hook, GetNewMessage());

        SaveData();
    }

    /// <summary>
    /// Return randomMessages[0], remove the entry form list
    /// </summary>
    /// <returns></returns>
    string GetNewMessage()
    {
        // If the list is empty, refill !
        if(randomMessages.Count == 0)
        {
            Debug.Log("List is empty");
            ResetMessages(allMessages);
        }

        string _newMessage = randomMessages[0];

        randomMessages.RemoveAt(0);

        return _newMessage;
    }

    void GetNewObject()
    {

    }

    public void NotBusyAnymore()
    {
        isBusy = false;
    }

    // Lists operations
    void ActualizeMessagesList()
    {
        // The list have less elements than the last time, reset it (that an odd behavior)
        if (allMessages.Count < nbrOfMessages)
        {
            ResetMessages(allMessages);
        }
        else
        if (allMessages.Count > nbrOfMessages)
        {
            // Add new messages to the possibilities

            List<string> _newMessages = new List<string>();

            // Fill the list with all the (fabulous) new messages add by the cuties developers
            for(int i = nbrOfMessages; i<allMessages.Count; i++)
            {

                _newMessages.Add(allMessages[i]);
            }

            foreach(string _message in _newMessages)
            {
                randomMessages.Add(_message);
            }

            if (randomMessages.Count > 1)
            {
                ResetMessages(randomMessages);
            }
        }

        nbrOfMessages = allMessages.Count;

    }

    /// <summary>
    /// Fill the randomMessages with the messages list, randomize 
    /// </summary>
    void ResetMessages(List<String> _fillWith)
    {
        randomMessages = new List<string>();

        List<String> _temporaryList = new List<string>();

        foreach(String _string in _fillWith)
        {
            _temporaryList.Add(_string);
        }

        int _index;

        for(int i = 0; i< _fillWith.Count; i++)
        {
            _index = UnityEngine.Random.Range(0, _temporaryList.Count);

            randomMessages.Add(_temporaryList[_index]);

>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5
            _temporaryList.RemoveAt(_index);

        }

    }

    void OnApplicationQuit()
    {
        SaveData();
    }

<<<<<<< HEAD
    void SaveData()
    {
=======
    /// <summary>
    /// Save Data
    /// </summary>
    void SaveData()
    {
        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetInt("NbrMessages", nbrOfMessages);

>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5
        // Last date
        PlayerPrefs.SetInt("Year", DateTime.Now.Year);
        PlayerPrefs.SetInt("Month", DateTime.Now.Month);
        PlayerPrefs.SetInt("Day", DateTime.Now.Day);
        PlayerPrefs.SetInt("Hours", DateTime.Now.Hour);
        PlayerPrefs.SetInt("Minutes", DateTime.Now.Minute);
        PlayerPrefs.SetInt("Secondes", DateTime.Now.Second);

        // Timer fishing
<<<<<<< HEAD
        TimeSpan _ts; 
        _ts = timerMessage.TimeOfDay;
        PlayerPrefs.SetInt("TimerMessage", (int)_ts.TotalMinutes);
        _ts = timerObject.TimeOfDay;
        PlayerPrefs.SetInt("TimerObject", (int)_ts.TotalMinutes);
=======
        PlayerPrefs.SetInt("TimerMessage", timerMessage);
        PlayerPrefs.SetInt("TimerObject", timerObject);
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5

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
        
        for (int i = 0; i < randomMessages.Count ; i++)
        {
            PlayerPrefs.SetString("RandomMessages" + i, randomMessages[i]);
        }
<<<<<<< HEAD
        
=======

        PlayerPrefs.SetInt("RandomMessages", randomMessages.Count);

        PlayerPrefs.Save();
        
    }

    bool CanHaveObject(int _seconds)
    {
        if (_seconds <= 0)
        {
            return false;
        }
        if ((float)_seconds/(60*(float)minutesBeforeObject)>1f)
        {
            return true;
        }
        else
        {
            return false;
        }
>>>>>>> 6ff15692e9773537af8851b5ad3eb5bce71520f5
    }

    bool CanHaveMessage(int _seconds)
    {
        if(_seconds<=0)
        {
            return false;
        }

        //if (_seconds / (86400 * dayBeforeMessage) > 1)
        if((float)_seconds/5f>1f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //DEBUG

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            canHaveAMessage = true;
        }
    }

}
