using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager wm;

    public GameObject blankWeapon;
    public GameObject[] handles, barrels, muzzles;

    public void GenerateWeapon(Vector2 pos)
    {
        GameObject weapon = Instantiate(blankWeapon, (Vector2)pos, Quaternion.identity);

        GameObject handle = Instantiate(handles[Random.Range(0, handles.Length)], weapon.transform);
        //handle.transform.localPosition = Vector2.zero;
        GameObject barrel = Instantiate(barrels[Random.Range(0, barrels.Length)], weapon.transform);
        //barrel.transform.localPosition = Vector2.zero;
        GameObject muzzle = Instantiate(muzzles[Random.Range(0, muzzles.Length)], weapon.transform);
        //muzzle.transform.localPosition = Vector2.zero;

        weapon.GetComponent<Weapon>().SetParts(handle, barrel, muzzle);
    }

    // Start is called before the first frame update
    void Awake()
    {
        wm = this;
    }

    // Update is called once per frame
    private void Start()
    {
        for (int i = -7; i < 10; i++)
        {
            GenerateWeapon(new Vector2(i, 0));
            i++;
        }
    }
}
