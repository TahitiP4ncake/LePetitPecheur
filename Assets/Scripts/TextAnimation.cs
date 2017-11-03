using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TextAnimation : MonoBehaviour
{
    string message;
    TextMeshProUGUI textComp;
    public float letterPause = 0.2f;

    void Start()
    {
        textComp = GetComponent<TextMeshProUGUI>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            /*if (typeSound1 && typeSound2)
                SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
                */
            yield return 0;
            yield return new WaitForSeconds(letterPause * (Random.Range(1f, 3f)));
        }
    }
}
