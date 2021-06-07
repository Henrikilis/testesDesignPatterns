using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Spell
{
    public override string Name => "Shield";

    public override void Process()
    {
        Debug.Log("SUMONEI SHIELD");
    }
}
