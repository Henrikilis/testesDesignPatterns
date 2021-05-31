using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{  
    void Start()
    {
       var melee = new MeleeCreator();
        melee.FactoryMethod();
    }
}
