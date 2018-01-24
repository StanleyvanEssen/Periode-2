using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject Weapon1;
    public GameObject Weapon2;
    public bool b;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("1"))
        {
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);
            b = true;
        }
        if (Input.GetButtonDown("2"))
        {
            Weapon1.SetActive(false);
            Weapon2.SetActive(true);
            b = false;
        }
	}
}
