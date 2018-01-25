using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool b;
    public float speed;

	void Update ()
    {
        if (b == true)
        {
            transform.Rotate(new Vector3(0,0,1)* speed);
        }
	}
}