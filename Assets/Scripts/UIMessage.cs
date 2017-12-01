using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIMessage : MonoBehaviour {

    public GameObject panel;

    public Text text;

    public void FillText(string _text)
    {
        text.text = _text;
    }

}
