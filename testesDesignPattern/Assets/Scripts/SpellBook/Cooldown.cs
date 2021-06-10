using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour
{
    public string spellName;
    public bool timerActive;
    public float cooldownTime;
    public GameObject ui;

    void Start()
    {
        ui = GameObject.Find(spellName + " Button");
    }

    void Update()
    {
        if (timerActive)
        {
            cooldownTime -= Time.deltaTime;
            ui.GetComponent<Slider>().value = cooldownTime;
            Debug.Log("Resfriando" + cooldownTime);
            if (cooldownTime <= 0)
            {
                timerActive = false;
                Debug.Log("Resfriou");
                ui.GetComponent<Slider>().value = ui.GetComponent<Slider>().maxValue;
            }
        }
    }
}
