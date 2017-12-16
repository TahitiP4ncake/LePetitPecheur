using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class UIManager : MonoBehaviour {

    [Header("Title")]
    public Animator titleScreenAnimator;

    [Header("Radeau")]
    public Animator radeauAnimator;

    [Header("Message")]
    public Animator messageAnimator;

    public Animator buttonOK;

    [Header("Buttons Options Animators")]
    public Animator dotAnimator;


    [Space()]

    public Animator help;

    public Animator options;

    public Animator quit;

    public Animator confirmation;

    [Space()]

    [Header("Text")]
    public TMP_Text messageText;


    bool isMenuOpen = false;

    // Start
    IEnumerator Start()
    {

        yield return new WaitForSeconds(1);

        titleScreenAnimator.SetTrigger("Disappear");

        //yield return new WaitForSeconds(0.5f);

        radeauAnimator.SetTrigger("Enter");

        yield return new WaitForSeconds(6);

        DisplayMenu();

    }

    #region Message

    public void DisplayMessage(string _text)
    {
        HideMenu();

        messageText.text = _text;
        messageAnimator.SetTrigger("Appear");

        Invoke("DisplayButtonOK", 2);
    }

    public void CloseMessage()
    {
        messageAnimator.SetTrigger("Disappear");

        Invoke("DisplayMenu", 1);
        Invoke("HideButtonOk", 2);
    }

    void DisplayButtonOK()
    {
        buttonOK.SetTrigger("Appear");
    }

    void HideButtonOk()
    {
        buttonOK.SetTrigger("Disappear");
    }

    #endregion

    #region Buttons Options

    #region Apparition and Hiding
    public void DotMenu()
    {
        if(isMenuOpen)
        {
            CloseMenu();
        }
        else
        {
            OpenMenu();
        }

        isMenuOpen = !isMenuOpen;
    }

    void OpenMenu()
    {
        dotAnimator.SetTrigger("Expand");

        help.SetTrigger("Appear");

        options.SetTrigger("Appear");

        quit.SetTrigger("Appear");
    }

    void CloseMenu()
    {
        dotAnimator.SetTrigger("Reduce");

        help.SetTrigger("Disappear");

        options.SetTrigger("Disappear");

        quit.SetTrigger("Disappear");
    }

    void HideMenu()
    {
        dotAnimator.SetTrigger("GetOut");
    }

    void DisplayMenu()
    {
        dotAnimator.SetTrigger("Appear");
    }
    #endregion

    public void Help()
    {

    }

    public void Option()
    {

    }



    #region Quit
    public void TryToQuit()
    {
        StartCoroutine(C_TryToQuit());
    }

    IEnumerator C_TryToQuit()
    {
        quit.SetTrigger("Disappear");

        yield return new WaitForSeconds(1);

        confirmation.SetTrigger("Appear");
    }

    public void DontQuit()
    {
        StartCoroutine(C_DontQuit());
    }

    IEnumerator C_DontQuit()
    {
        confirmation.SetTrigger("Disappear");

        yield return new WaitForSeconds(1);

        quit.SetTrigger("Appear");
    }

    #endregion


    #endregion

    // Singleton
    public static UIManager instance = null;

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
