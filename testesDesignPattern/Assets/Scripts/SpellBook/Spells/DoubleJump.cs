using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : Spell
{
    public override string Name => "Double Jump";
    //public float cooldownTime = 5;

    public override void Process()
    {
        Debug.Log("PULEI");
        cooldownTime = 5;
        timerActive = true;
    }
}
