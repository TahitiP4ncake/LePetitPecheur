using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class MenuAnimation : MonoBehaviour {

    public enum actionSelected { Help, Credit, Message, Music }

    float timer;
    public float cooldown;

    #region Texts

    public GameObject menuHidden;
    public GameObject menuVisible;

    bool visible;

    public GameObject quitConfirmation;
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

    #endregion

    public FishermanAnimator fisher;

    void Start()
    {
        /*
        visible = true;
        SwitchMenu();
        */
       
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
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
                visible = true;
                menuHidden.SetActive(false);
                menuVisible.SetActive(true);
                for (int i = 0; i < 3; i++)
                {
                    StartCoroutine(DotOn(i));
                }
                timer = cooldown;   
                break;
            case true:
                visible = false;
                menuHidden.SetActive(true);
                menuVisible.SetActive(false);
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
                quit.gameObject.SetActive(false);
                quitConfirmation.SetActive(true);
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
        timer = cooldown;

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
                quit.text = "quit";
                break;

            case "Confirmation":
                quitConfirmation.SetActive(false);
                quit.gameObject.SetActive(true);
                break;

            case "Bottle":
                action.text = "";
                break;
        }
    }

    public void Quit()
    {
        //Application.Quit();
        print("Ferme l'application et sauvegarde la progression avant ça peut etre");
    }

    public void Read() // quand on clique sur le joueur et qu'un message a été reçu
    {
        fisher.PlayAnimation(AnimationState.MessageOn);
        action.text = "";
        SwitchBottle();
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
        print("Fade In");
        //_text.color = new Color(1, 1, 1, 0);
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
}
