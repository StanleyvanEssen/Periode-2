using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator2 : MonoBehaviour
{
    public Vector3 v2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        v2.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(v2);
    }
}
