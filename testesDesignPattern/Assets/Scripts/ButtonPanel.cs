using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFactory;

public class ButtonPanel : MonoBehaviour
{
    public void Fire()
    {
        AbilityFactory.GetAbility("fire");
        Debug.Log("APERTEI FOGO");
    }
    public void Heal()
    {
        AbilityFactory.GetAbility("heal");
    }
}
