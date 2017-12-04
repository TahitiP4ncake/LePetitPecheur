using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    [Header("Animator")]
    public Animator DotAnimator;

    public Animator TitleScreenAnimator;

    public Animator RadeauAnimator;


    ///


    IEnumerator Start()
    {


        yield return new WaitForSeconds(1);

        TitleScreenAnimator.SetTrigger("Disappear");

        //yield return new WaitForSeconds(0.5f);

        RadeauAnimator.SetTrigger("Enter");

        yield return new WaitForSeconds(6);

        DotAnimator.SetTrigger("Appear");

    }




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
