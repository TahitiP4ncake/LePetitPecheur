using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Usable : Treasure {

    bool freeToBeUsed = true;

    public void OnMouseDown()
    {
        if(freeToBeUsed == false)
        {
            return;
        }

        DoSomething();

    }

    protected virtual void DoSomething()
    {
        freeToBeUsed = false;
    }

    public void OkToUse()
    {
        freeToBeUsed = true;
    }

}
