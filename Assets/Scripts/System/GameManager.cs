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
        // Initialize system
        saveSystem.InitializeSaveSystem();

        messageManager.InitializeMessages();

        // System settings
		Application.runInBackground = true;

        // Start to count the time passed
        StartCoroutine(TimePassed());
    }


    IEnumerator TimePassed()
    {

        yield return new WaitForSeconds(2);

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
            else
            {
                saveFile.canHaveMessage = false;

                isBusy = true;

                SendNewMessage();
            }

            /* No objects for this version
            if (saveFile.canHaveObject == false)
            {
                saveFile.timerObject++;

                if (messageManager.CanHaveObject(saveFile.timerObject))
                {
                    saveFile.timerObject = 0;
                    saveFile.canHaveObject = true;
                }

            }
            else
            {
                saveFile.canHaveObject = false;

                isBusy = true;

                messageManager.GetNewObject();
            }
            */
        }
    }

    void SendNewMessage()
    {
        // Send new message and play the animation
        fisherAnimator.PlayAnimation(AnimationState.Hook);

        saveSystem.SaveData();
    }

    public void NotBusyAnymore()
    {
        isBusy = false;
    }

    public void Quit()
    {
        saveSystem.SaveData();
        StopAllCoroutines();
        Application.Quit();
    }

    // Singleton
    public static GameManager instance = null;

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }


}
