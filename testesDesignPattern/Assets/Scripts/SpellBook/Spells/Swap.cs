using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swap : Spell
{
    public override string Name => "Swap";
    float coolTime = 1;

    public override void Process()
    {
        cooldown = GameObject.Find(Name + " Cooldown");
        ui = GameObject.Find(Name + " Button");

        Debug.Log("SUMONEI " + Name);
        cooldown.GetComponent<Cooldown>().cooldownTime = coolTime;
        cooldown.GetComponent<Cooldown>().timerActive = true;
        ui.GetComponent<Slider>().maxValue = coolTime;
    }
}
