using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public List<int> il = new List<int>();

	// Use this for initialization
	void Start ()
    {
        il.AddRange(Random.Range(10,13));
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
}