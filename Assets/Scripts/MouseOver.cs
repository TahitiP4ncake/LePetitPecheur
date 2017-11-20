using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler// required interface when using the OnPointerEnter method.
{
    public enum actionList
    {
        Quit,
        Confirmation,
        Menu,
        MessageFinished,
        Bottle,
        Help,
        Credit,
        HelpOver,
        CreditOver,
		Radio
    }

    public actionList action;

    public MenuAnimation menu;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (action != actionList.Quit && action != actionList.Confirmation && action!= actionList.Menu && action != actionList.MessageFinished && action != actionList.Radio)
            menu.Show(action.ToString());
        //Debug.Log(actionSelected);

        if(action ==actionList.Bottle )
        {
            StartCoroutine(menu.HideMenu(true,"read"));
        }

        if (action == actionList.Radio)
        {
            StartCoroutine(menu.HideMenu(true, "listen"));
        }

        if (action == actionList.Quit)
        {
            menu.timer = 0;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        if(action!=actionList.Menu && action != actionList.Bottle && action != actionList.MessageFinished && action!=actionList.Radio)
            menu.Hide(action.ToString());

        if(action == actionList.Bottle || action == actionList.Radio)
        {
            StartCoroutine(menu.HideMenu(false, ""));
        }

        //Debug.Log("The cursor exited the selectable UI element.");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(action == actionList.Quit || action== actionList.Menu )
        menu.Show(action.ToString());

        if (action == actionList.Confirmation)
            menu.Quit();

        if (action == actionList.Bottle)
        {
            menu.Read();
        }

        if(action ==actionList.Radio)
        {
            menu.fisher.PlayAnimation(AnimationState.RadioOn);
        }


        if( action == actionList.MessageFinished)
        {
            menu.FinishedReading();
        }
        
    }

}
