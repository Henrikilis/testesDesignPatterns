﻿using ReflectionFactoryStatic;
using UnityEngine;

public class ButtonPanel : MonoBehaviour
{
    [SerializeField]
    private AbilityButton buttonPrefab;

    private void OnEnable()
    {
        foreach (string name in AbilityFactory.GetAbilityNames2())
        {
            var button = Instantiate(buttonPrefab);
            button.gameObject.name = name + " Button";
            button.SetAbilityName(name);
            button.transform.SetParent(transform);
        }
    }
}
