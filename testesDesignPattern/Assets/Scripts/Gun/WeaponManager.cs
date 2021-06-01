using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager wm;

    public GameObject blankWeapon;
    public GameObject[] handles, barrels, muzzles;

    public void GenerateWeapon(Vector2 pos)
    {
        GameObject weapon = Instantiate(blankWeapon, (Vector2)pos, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Awake()
    {
        wm = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
