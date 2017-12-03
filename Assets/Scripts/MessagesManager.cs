using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MessagesManager : MonoBehaviour {

    public GameManager gameManager;

    [Header("Messages")]
    // All the messages in the .CSV
    public List<string> allMessages = new List<string>();

    // List of all messages not displayed yet, randomized
    public List<string> randomMessages = new List<string>();


    // Private
    const int dayBeforeMessage = 1;

    int minutesBeforeObject = 20;

    //////////////////////////////////////


    public void InitializeMessages()
    {
        // Get all the messages from the .CSV
        allMessages = CSVReader.Read("Messages");

        // If the .CSV change since the last time (aka new messages)
        if (allMessages.Count != gameManager.saveFile.nbrMessages)
        {
            ActualizeMessagesList();
        }

        // Save the actual settings
        PlayerPrefs.Save();

        if (randomMessages.Count == 0)
        {
            ResetMessages(allMessages);
        }

        // Define minutes before new objects
        minutesBeforeObject = UnityEngine.Random.Range(20, 32);
    }

    // Lists operations
    void ActualizeMessagesList()
    {
        // The list have less elements than the last time, reset it (that an odd behavior)
        if (allMessages.Count < gameManager.saveFile.nbrMessages)
        {
            ResetMessages(allMessages);
        }
        else
        if (allMessages.Count > gameManager.saveFile.nbrMessages)
        {
            // Add new messages to the possibilities

            List<string> _newMessages = new List<string>();

            // Fill the list with all the (fabulous) new messages add by the cuties developers
            for (int i = gameManager.saveFile.nbrMessages; i < allMessages.Count; i++)
            {

                _newMessages.Add(allMessages[i]);
            }

            foreach (string _message in _newMessages)
            {
                randomMessages.Add(_message);
            }

            if (randomMessages.Count > 1)
            {
                ResetMessages(randomMessages);
            }
        }

        gameManager.saveFile.nbrMessages = allMessages.Count;

    }

    /// <summary>
    /// Fill the randomMessages with the messages list, randomize 
    /// </summary>
    void ResetMessages(List<string> _fillWith)
    {
        randomMessages = new List<string>();

        List<String> _temporaryList = new List<string>();

        foreach (String _string in _fillWith)
        {
            _temporaryList.Add(_string);
        }

        int _index;

        for (int i = 0; i < _fillWith.Count; i++)
        {
            _index = UnityEngine.Random.Range(0, _temporaryList.Count);

            randomMessages.Add(_temporaryList[_index]);

            _temporaryList.RemoveAt(_index);

        }

    }

    public bool CanHaveObject(int _seconds)
    {
        if (_seconds <= 0)
        {
            return false;
        }
        if ((float)_seconds / (60 * (float)minutesBeforeObject) > 1f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CanHaveMessage(int _seconds)
    {
        if (_seconds <= 0)
        {
            return false;
        }

        //if (_seconds / (86400 * dayBeforeMessage) > 1)
        if ((float)_seconds / 5f > 1f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Return randomMessages[0], remove the entry form list
    /// </summary>
    /// <returns></returns>
    public string GetNewMessage()
    {
        // If the list is empty, refill !
        if (randomMessages.Count == 0)
        {
            Debug.Log("List is empty");
            ResetMessages(allMessages);
        }

        string _newMessage = randomMessages[0];

        randomMessages.RemoveAt(0);

        return _newMessage;
    }

    public void GetNewObject()
    {

    }

    /*
    void DeterminePossibilities()
    {
        TimeSpan _ts = DateTime.Now - lastDate;

        if (_ts.TotalDays > 1)
        {
            gameManager.saveFile.canHaveMessage = true;
        }
    }
    */

}
