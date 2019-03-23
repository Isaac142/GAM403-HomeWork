using UnityEngine;
using System.Collections;

public class ChangeWeapons : MonoBehaviour
{
    public GameObject[] weapons;
    public float normalSpeed = 0.05f;        //Attempt at making different weapons give different speed movements
    public float knifeSpeed = 0.10f;

    void Start()
    {
        Cursor.visible = false;
        Debug.Log(weapons.Length);
        WeaponSwap(0);
    }

    void Update()           //Calling onto the "WeaponSwap" function instead of writing the whole thing over and over, allowing modellers to add more weapons without having to rewrite the whole script
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponSwap(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponSwap(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            WeaponSwap(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            WeaponSwap(3);
        }
    }

    void WeaponSwap(int weaponNumber)        //created this function to not make less repetetive scripts in the update function
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (i != weaponNumber)
                weapons[i].SetActive(false);
            else
                weapons[i].SetActive(true);

        }
    }
}
