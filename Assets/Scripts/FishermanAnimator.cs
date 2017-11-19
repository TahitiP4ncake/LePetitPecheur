using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationState
{
    Hook,
    MessageOn,
    MessageOff,
    RadioOn
}

public class FishermanAnimator : MonoBehaviour {

    public Animator anim;

    public LineRenderer fil;

    public GameObject filHead;
    public GameObject filTail;

    public GameObject canneTrue;
    public GameObject canneFalse;

    public GameObject bouteilleTrue;
    public GameObject bouteilleFalse;

    public GameObject bouchon;
    public GameObject message;

    public GameObject radeau;

    Vector3 origin;

    public AnimationCurve x;
    public AnimationCurve z;

    public MenuAnimation menu;

    [Space]

    public Material bouteilleMaterial;

    public ParticleSystem radioParticle;

    [Space]

    public GameManager manager;

    public string messageToDisplay;

    public void PlayAnimation(AnimationState _animation, string _message ="")
    {
        anim.SetTrigger(_animation.ToString());

        if (_message != "")
        {
            messageToDisplay = _message;
        }
    }

    void Start()
    {
        origin = radeau.transform.eulerAngles;
        BouteilleOff();
    }
    void Update () 
	{
        DrawFil(); //line renderer fil de peche


        //Debug inputs.

        /*
		if(Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimation(AnimationState.Hook);
           
        }
        

        if (Input.GetKeyDown(KeyCode.Z))
        {
            PlayAnimation(AnimationState.RadioOn);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayAnimation(AnimationState.MessageOff);
        }
        */

        Tilt();
    }


    void Tilt()
    {
        radeau.transform.eulerAngles = new Vector3(origin.x + x.Evaluate(Time.time), origin.y,origin.z + z.Evaluate(Time.time));
    }

    void DrawFil()
    {
        fil.SetPosition(0, filHead.transform.position);
        fil.SetPosition(1, filTail.transform.position);
    }

    #region Activate/Desactivate Objects

    void CanneOn()
    {
        canneFalse.transform.position = canneTrue.transform.position;
        canneFalse.transform.rotation = canneTrue.transform.rotation;
        canneFalse.transform.SetParent(canneTrue.transform);
        canneTrue.SetActive(true);
        canneFalse.SetActive(false);


        //faire lerper la canne de sa position à sa main
        //ou alors cleaner l'anim
        // :)
    }

     void CanneOff()
    {
        canneFalse.transform.position = canneTrue.transform.position;
        canneFalse.transform.rotation = canneTrue.transform.rotation;
        canneFalse.transform.SetParent(null);

        canneTrue.SetActive(false);
        canneFalse.SetActive(true);
    }
    
    void ActivateBouteille(bool _activate)
    {
        bouteilleTrue.SetActive(_activate);
        bouchon.SetActive(_activate);
        message.SetActive(_activate);
    }


    /// <summary>
    /// Activates the bottle, bottle cap and the message (meshes).
    /// </summary>
     void BouteilleOn()  
    {
        bouteilleTrue.SetActive(true);
        bouchon.SetActive(true);
        message.SetActive(true);

        //StartCoroutine(FadeBottle(true));
    }

    /// <summary>
    /// Desactivates the bottle, bottle cap and the message (meshes).
    /// </summary>
    void BouteilleOff()
    {
        bouteilleTrue.SetActive(false);
        bouchon.SetActive(false);
        message.SetActive(false);


        manager.NotBusyAnymore();

        //StartCoroutine(FadeBottle(false));
    }

    /// <summary>
    /// Sets the position of the non-animated bottle on the boat and sets its parent to world.
    /// And hides the animated bottle.
    /// </summary>
    void StockOn()
    {
        menu.SwitchBottle();
        bouteilleFalse.transform.position = bouteilleTrue.transform.position;
        bouteilleFalse.transform.rotation = bouteilleTrue.transform.rotation;
        bouteilleFalse.transform.SetParent(null);

        bouteilleFalse.SetActive(true);

        bouteilleTrue.SetActive(false);
        bouchon.SetActive(false);
        message.SetActive(false);
    }

    void StockOff()
    {
        bouteilleFalse.transform.SetParent(bouteilleTrue.transform);

        bouteilleFalse.SetActive(false);
        bouteilleTrue.SetActive(true);
        bouchon.SetActive(true);
        message.SetActive(true);
    }

    void RadioOn()
    {
        //La faut lancer le morceau de musique 

        // COUCOU BAPTISTE !!

        //<3

        radioParticle.Play(); //A stopper quand le morceau est finis.
    }


    #endregion

    void Reading()
    {
        StartCoroutine(menu.Reading(messageToDisplay));
    }

    IEnumerator FadeBottle(bool on)
    {

        float _opacity = bouteilleMaterial.GetFloat("_Opacity");

        switch (on)
        {
            case true:

                bouteilleMaterial.SetFloat("_Opacity", 0);

                while (bouteilleMaterial.GetFloat("_Opacity")<.28f)
                {
                    print(_opacity);
                    _opacity += Time.deltaTime;

                    bouteilleMaterial.SetFloat("_Opacity", _opacity);
                    yield return null;
                }

                bouteilleMaterial.SetFloat("_Opacity", .28f);

                bouteilleTrue.SetActive(true);
                bouchon.SetActive(true);
                message.SetActive(true);


                break;

            case false:
                print("je cache la bouteille");

                while (bouteilleMaterial.GetFloat("_Opacity") > 0)
                {
                    _opacity -= Time.deltaTime;

                    bouteilleMaterial.SetFloat("_Opacity", _opacity );
                    yield return null;
                }

                bouteilleMaterial.SetFloat("_Opacity", 0);

                bouteilleTrue.SetActive(false);
                bouchon.SetActive(false);
                message.SetActive(false);


                manager.NotBusyAnymore();

                break;
        }
    }
}
