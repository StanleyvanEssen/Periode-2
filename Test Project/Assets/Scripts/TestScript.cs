﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        TestVoid(15);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void TestVoid(int i)
    {
        i += 2;
        print(i);
    }
}
