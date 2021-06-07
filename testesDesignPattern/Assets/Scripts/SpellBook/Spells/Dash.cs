using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : Spell
{
    public override string Name => "Dash";

    public override void Process()
    {
        Debug.Log("FIZ DASH");
    }
}
