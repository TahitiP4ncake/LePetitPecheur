using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationState
{
    Hook,
    MessageOn,
    MessageOff
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

    public void PlayAnimation(AnimationState _animation)
    {
        anim.SetTrigger(_animation.ToString());
    }

    void Start()
    {
        origin = radeau.transform.eulerAngles;
        BouteilleOff();
    }
    void Update () 
	{
        DrawFil();

		if(Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimation(AnimationState.Hook);
           
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            PlayAnimation(AnimationState.MessageOn);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayAnimation(AnimationState.MessageOff);
        }

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

     void CanneOn()
    {
        canneFalse.transform.position = canneTrue.transform.position;
        canneFalse.transform.rotation = canneTrue.transform.rotation;
        canneFalse.transform.SetParent(canneTrue.transform);
        canneTrue.SetActive(true);
        canneFalse.SetActive(false);
    }

     void CanneOff()
    {
        canneFalse.transform.position = canneTrue.transform.position;
        canneFalse.transform.rotation = canneTrue.transform.rotation;
        canneFalse.transform.SetParent(null);

        canneTrue.SetActive(false);
        canneFalse.SetActive(true);
    }

     void BouteilleOn()
    {
        bouteilleTrue.SetActive(true);
        bouchon.SetActive(true);
        message.SetActive(true);
    }

     void BouteilleOff()
    {
        bouteilleTrue.SetActive(false);
        bouchon.SetActive(false);
        message.SetActive(false);
    }

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
}
