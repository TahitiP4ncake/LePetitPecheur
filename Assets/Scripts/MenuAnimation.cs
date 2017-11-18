using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class MenuAnimation : MonoBehaviour {

    public enum actionSelected { Help, Credit, Message, Music }

    //[HideInInspector]
    public float timer;
    public float timerMax;

    #region Texts

    public GameObject menuHidden;
    public GameObject menuVisible;

    bool visible;

    public TextMeshProUGUI quitConfirmation;
    public TextMeshProUGUI quit;

    public TextMeshProUGUI help;
    public TextMeshProUGUI helpOver;

    public TextMeshProUGUI credit;
    public TextMeshProUGUI creditOver;

    public GameObject bottle;

    public TextMeshProUGUI action;

    public List<TextMeshProUGUI> texts;

    public List<GameObject> dots;
    public List<GameObject> dotOrigin;
    public List<GameObject> dotTarget;

    [Space]

    public float lerpSpeed;

    [Space]

    public TextMeshProUGUI message;

    public TextMeshProUGUI messageConfirmation;

    #endregion

    public FishermanAnimator fisher;

    void Start()
    {
        /*
        visible = true;
        SwitchMenu();
        */

        message.color = new Color(1, 1, 1, 0);
    }

    IEnumerator WaitBeforeClosingMenu()
    {
        while(timer>0)
        {
            yield return new WaitForSeconds(0.01f);
            timer -= 0.01f;
            if (timer <= 0)
            {
                timer = 0;

                SwitchMenu();
            }
        }
    }

    void SwitchMenu() //Switch menu On/Off
    {
        switch (visible)
        {
            case false:
               // print("faux");
                visible = true;
                menuHidden.SetActive(false);
                foreach (TextMeshProUGUI _text in texts)
                {
                    StartCoroutine(FadeIn(_text));
                }
                menuVisible.SetActive(true);
                for (int i = 0; i < 3; i++)
                {
                    StartCoroutine(DotOn(i));
                }
                timer = timerMax;

                StartCoroutine(WaitBeforeClosingMenu());

                break;
            case true:
                
                visible = false;
                
                Hide("HelpOver");
                Hide("CreditOver");

                StartCoroutine(FadeOutSimple(credit));
                StartCoroutine(FadeOutSimple(help));
                StartCoroutine(FadeOutSimple(quit));

                StartCoroutine(CloseMenu());  //Delay de la fermeture du menu

                for (int i = 0; i < 3; i++)
                {
                    StartCoroutine(DotOff(i));
                }

                break;
        }
    }

    public void Show(string _action)
    {
        timer = 0;

        switch(_action)
        {
            case "Help":

                // help.text = "a new message each day, be patient";
                
                StartCoroutine(FadeOut(help,helpOver));
                break;

            case "Credit":

                // credit.text = "a companion by baba and dodo";

                StartCoroutine(FadeOut(credit,creditOver));
                break;

            case "Quit":
                /*
                quit.gameObject.SetActive(false);
                quitConfirmation.SetActive(true);
                */
                StartCoroutine(FadeOut(quit, quitConfirmation));
                break;

            case "Menu":
                SwitchMenu();
                break;

            case "Bottle":
                action.text = "read";
                break;
           
        }
    }

    public void Hide(string _action)
    {
        timer = timerMax;

        switch (_action)
        {
            case "HelpOver":

                StartCoroutine(FadeOut(helpOver,help));
                
                

                //help.text = "help";
                break;

            case "CreditOver":

               
                StartCoroutine(FadeOut(creditOver,credit));

                //credit.text = "credit";
                break;

            case "Quit":
                //quit.text = "quit";
                break;

            case "Confirmation":
                //quitConfirmation.gameObject.SetActive(false);
                StartCoroutine(FadeOut(quitConfirmation, quit));
                //quit.gameObject.SetActive(true);
                break;

            case "Bottle":
                action.text = "";
                break;
        }
    }

    public void Quit() //need baba
    {
        //Un jour peut etre il faudra call une fonction plus propre :)
        //courage
        Application.Quit();
        //print("Ferme l'application et sauvegarde la progression avant ça peut etre");
    }

    public void Read() // quand on clique sur le joueur et qu'un message a été reçu
    {
        fisher.PlayAnimation(AnimationState.MessageOn);
        action.text = "";
        SwitchBottle();
    }


    /// <summary>
    /// Sets the message's text, launch the fade in of the text, then show the button to close the message 
    /// </summary>
    /// <param name="_message">  This is the message the player will be able to read</param>
    /// <returns></returns>
    public IEnumerator Reading(string _message)
    {
        message.text = _message;
        StartCoroutine(FadeIn(message));
        yield return new WaitForSeconds(1);
        messageConfirmation.gameObject.SetActive(true);
        StartCoroutine(FadeIn(messageConfirmation));

    }

    public void FinishedReading()
    {
    
        StartCoroutine(FadeOutSimple(messageConfirmation));
        StartCoroutine(FadeOutSimple(message));
        

        
        fisher.PlayAnimation(AnimationState.MessageOff);
       
    }

    public void SwitchBottle() //active/desactive la hitbox pour lire le message 
    {
        bottle.SetActive(!bottle.activeSelf);
    }

    IEnumerator DotOn(int _index)
    {
        for (float i = 0; i < 1;)
        {
            dots[_index].transform.position = Vector3.Lerp(dotOrigin[_index].transform.position, dotTarget[_index].transform.position, i);
            i += Time.deltaTime*lerpSpeed;
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator DotOff(int _index)
    {
        for (float i = 0; i < 1;)
        {
            dots[_index].transform.position = Vector3.Lerp(dotTarget[_index].transform.position, dotOrigin[_index].transform.position, i);
            i += Time.deltaTime* lerpSpeed;
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator FadeIn(TextMeshProUGUI _text)
    {
        _text.color = new Color(1, 1, 1, 0);
        _text.gameObject.SetActive(true);

        for (float i = 0; i < .3f; i+=Time.deltaTime)
        {
            _text.color = new Color(1, 1, 1, (1 / .3f) * i);
            yield return new WaitForEndOfFrame();
        }
        //_text.color = new Color(1, 1, 1, 1);
    }

    IEnumerator FadeOut(TextMeshProUGUI _text, TextMeshProUGUI nextText)
    {
        for (float i = 0; i < .3f; i += Time.deltaTime)
        {
            _text.color = new Color(1, 1, 1, 1-(1 / .3f) * i);
            yield return new WaitForEndOfFrame();
        }
        _text.color = new Color(1, 1, 1, 0);
        _text.gameObject.SetActive(false);

        StartCoroutine(FadeIn(nextText));
    }

    IEnumerator FadeOutSimple(TextMeshProUGUI _text)
    {
        for (float i = 0; i < .3f; i += Time.deltaTime)
        {
            _text.color = new Color(1, 1, 1, 1 - (1 / .3f) * i);
            yield return new WaitForEndOfFrame();
        }
        _text.color = new Color(1, 1, 1, 0);
        _text.gameObject.SetActive(false);

    }

    IEnumerator CloseMenu()
    {
        yield return new WaitForSeconds(.3f);
        timer = 0;
        menuHidden.SetActive(true);
        menuVisible.SetActive(false);
    }
}
