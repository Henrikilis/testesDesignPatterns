using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButton : MonoBehaviour
{
    public Text name;

    public void SetAbilityName(string x)
    {
        name.text = x;
    }
}
