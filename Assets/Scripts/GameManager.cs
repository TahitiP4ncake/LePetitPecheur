using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour {

    [Header("Managers")]
    public SaveSystem saveSystem;

    public MessagesManager messageManager;

    public FishermanAnimator fisherAnimator;

    [Header("Save file")]
    public SaveFile saveFile;

    bool isBusy = false;

	// Use this for initialization
	void Start ()
    {
        saveSystem.InitializeSaveSystem();

        messageManager.InitializeMessages();

        // System settings
		Application.runInBackground = true;

        // Start to count the time passed
        StartCoroutine(TimePassed());
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

            if (saveFile.canHaveMessage == false)
            {
                saveFile.timerMessage++;

                if (messageManager.CanHaveMessage(saveFile.timerMessage))
                {
                    saveFile.timerMessage = 0;
                    saveFile.canHaveMessage = true;
                }

            }

            if (saveFile.canHaveObject == false)
            {
                saveFile.timerObject++;

                if (messageManager.CanHaveObject(saveFile.timerObject))
                {
                    saveFile.timerObject = 0;
                    saveFile.canHaveObject = true;
                }

            }

            if (saveFile.canHaveMessage)
            {
                saveFile.canHaveMessage = false;

                isBusy = true;

                SendNewMessage();
            }

            if (saveFile.canHaveObject)
            {
                saveFile.canHaveObject = false;

                isBusy = true;

                messageManager.GetNewObject();
            }

        }
    }

    void SendNewMessage()
    {
        // Send new message and play the animation
        fisherAnimator.PlayAnimation(AnimationState.Hook, messageManager.GetNewMessage());

        saveSystem.SaveData();
    }

   

    public void NotBusyAnymore()
    {
        isBusy = false;
    }



}
