﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public int hp;
    public Light l;
    public Material Material1;
    public UpAndDown checkUAD;

    void Start()
    {
        checkUAD = gameObject.GetComponent<UpAndDown>();
    }

    public void LoseHP(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            gameObject.GetComponent<Renderer>().material = Material1;
            gameObject.GetComponent<Rotator>().b = true;
            Destroy(l);
            Destroy(checkUAD);
        }
    }
}