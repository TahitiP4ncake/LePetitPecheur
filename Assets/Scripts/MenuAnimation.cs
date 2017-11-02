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

    #endregion

    public FishermanAnimator fisher;

    void Start()
    {
        visible = true;
        SwitchMenu();
       
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
                timer = cooldown;   
                break;
            case true:
                visible = false;
                menuHidden.SetActive(true);
                menuVisible.SetActive(false);
                
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
                help.gameObject.SetActive(false);
                helpOver.gameObject.SetActive(true);
                break;

            case "Credit":

                // credit.text = "a companion by baba and dodo";
                credit.gameObject.SetActive(false);
                creditOver.gameObject.SetActive(true);
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
            case "Help":

                help.gameObject.SetActive(true);
                helpOver.gameObject.SetActive(false);

                //help.text = "help";
                break;

            case "Credit":

                credit.gameObject.SetActive(true);
                creditOver.gameObject.SetActive(false);

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

        //Il manque comment cacher le menu, est-ce un timer ou alors quand on clique ailleurs ça le cache
    }

    public void Quit()
    {
        //Application.Quit();
        print("Ferme l'application et sauvegarde la progression avant ça peut etre");
    }

    public void Read()
    {
        fisher.PlayAnimation(AnimationState.MessageOn);
        action.text = "";
        SwitchBottle();
    }

    public void SwitchBottle()
    {
        bottle.SetActive(!bottle.activeSelf);
    }
    
}
