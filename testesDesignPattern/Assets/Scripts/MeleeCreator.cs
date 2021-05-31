using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponCreator;

class MeleeCreator : Creator
{
    public override IWeapon FactoryMethod()
    {
        return new Axe();
    }
}

