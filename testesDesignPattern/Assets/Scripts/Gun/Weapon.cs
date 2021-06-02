using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage, speed, knockback;
    public float durability, maxDurability;
    public string weaponName;

    Handle handle;
    Barrel barrel;
    Muzzle muzzle;

    public void GetStats()
    {
        damage = handle.damage + barrel.damage + muzzle.damage;
        speed = handle.speed + barrel.speed + muzzle.speed;
        knockback = handle.knockback + barrel.knockback + muzzle.knockback;
        durability = handle.durability + barrel.durability + muzzle.durability;
        maxDurability = durability;
    }

    public void SetParts(GameObject h, GameObject b, GameObject m)
    {
        handle = h.GetComponent<Handle>();
        barrel = b.GetComponent<Barrel>();
        muzzle = m.GetComponent<Muzzle>();

        GetStats();
    }
}
