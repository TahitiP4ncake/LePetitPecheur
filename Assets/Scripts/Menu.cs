using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Menu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image boutton;

    void Start()
    {
        StartCoroutine(FadeOut());
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        boutton.color = new Color(boutton.color.r, boutton.color.g, boutton.color.b, 1);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(FadeOut());

    }

    IEnumerator FadeOut()
    {
        float _alpha = boutton.color.a;

        while (boutton.color.a>0)
        {
            _alpha -= 0.0001f;

            boutton.color = new Color(boutton.color.r, boutton.color.g, boutton.color.b, _alpha);

            yield return new WaitForSeconds(0.01f);
            Debug.Log(_alpha);
        }
    }

    public void Click()
    {
        Debug.Log("Click");
    }


}
