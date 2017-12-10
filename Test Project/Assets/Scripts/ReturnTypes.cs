using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTypes : MonoBehaviour
{
    public float resultaat;

	// Use this for initialization
	void Start ()
    {
        resultaat = Btw(100);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public float Btw (float bruto)
    {
        return bruto * 1.21f;
    }
}
