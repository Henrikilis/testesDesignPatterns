using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MonoBehaviour
{
    public string spellName;
    public bool timerActive;
    public float cooldownTime;

    void Update()
    {
        if (timerActive)
        {
            cooldownTime -= Time.deltaTime;
            Debug.Log("Resfriando" + cooldownTime);
            if (cooldownTime <= 0)
            {
                timerActive = false;
                Debug.Log("Resfriou");
            }
        }
    }
}
