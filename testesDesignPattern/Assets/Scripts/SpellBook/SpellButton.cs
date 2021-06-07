using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour
{
    public Text name;

    public void SetSpellName(string x)
    {
        name.text = x;
    }
}
