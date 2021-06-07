using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ReflectionFactoryStatic;

public class SpellHud : MonoBehaviour
{
    [SerializeField]
    private SpellButton spellPrefab;

    private void OnEnable()
    {
        foreach (string name in SpellFactory.GetSpellNames2())
        {
            var button = Instantiate(spellPrefab);
            button.gameObject.name = name + " Button";
            button.SetSpellName(name);
            button.transform.SetParent(transform);
        }
    }
}
