using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SaveFile
{
    public int nbrMessages;

    public int year, month, day, hours, minutes, secondes;

    public int timerMessage, timerObject;

    public bool canHaveMessage;

    public bool canHaveObject;

    public List<string> randomMessages = new List<string>();


}
