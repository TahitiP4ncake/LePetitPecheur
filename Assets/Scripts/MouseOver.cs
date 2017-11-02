using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler// required interface when using the OnPointerEnter method.
{

    public MenuAnimation menu;

    public string actionSelected;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (actionSelected != "Quit" && actionSelected != "Confirmation" && actionSelected!="Menu")
            menu.Show(actionSelected);
        //Debug.Log("The cursor entered the selectable UI element.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        menu.Hide(actionSelected);
        //Debug.Log("The cursor exited the selectable UI element.");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(actionSelected =="Quit" || actionSelected=="Menu")
        menu.Show(actionSelected);

        if (actionSelected == "Confirmation")
            menu.Quit();
        //Debug.Log("The cursor clicked the selectable UI element.");
    }

}
