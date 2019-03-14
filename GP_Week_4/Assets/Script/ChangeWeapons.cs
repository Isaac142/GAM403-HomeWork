using UnityEngine;
using System.Collections;

public class ChangeWeapons : MonoBehaviour
{
    public GameObject[] weapons;
    public float normalSpeed = 0.05f;
    public float knifeSpeed = 0.10f;

    void Start()
    {
        Cursor.visible = false;
        Debug.Log(weapons.Length);
        WeaponSwap(0);
    }

    void Update()
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

    void WeaponSwap(int weaponNumber)
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
