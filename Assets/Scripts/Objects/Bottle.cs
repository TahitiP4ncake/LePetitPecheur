using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : Usable {

    protected override void DoSomething()
    {
        base.DoSomething();

        UIManager.instance.DisplayMessage();

    }

}
