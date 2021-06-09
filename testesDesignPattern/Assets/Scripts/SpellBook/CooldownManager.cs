using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownManager : MonoBehaviour
{
    public GameObject cooldownPrefab;

    private void OnEnable()
    {
        foreach (string name in SpellFactory.GetSpellNames2())
        {
            var cd = Instantiate(cooldownPrefab);
            cd.gameObject.name = name + " Cooldown";
            cd.GetComponent<Cooldown>().spellName = name;
            cd.transform.SetParent(transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
