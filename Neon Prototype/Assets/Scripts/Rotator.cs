using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool b;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        b = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(b == true)
        {
            transform.Rotate(new Vector3(0,1,0)* speed);
        }
	}
}
