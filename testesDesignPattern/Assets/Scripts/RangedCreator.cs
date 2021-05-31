using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponCreator;

class RangedCreator : Creator
{
    public override IWeapon FactoryMethod()
    {
        return new Revolver();
    }
}
