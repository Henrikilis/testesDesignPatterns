using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : Spell
{
    public override string Name => "Shield";
    float coolTime = 10;

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
