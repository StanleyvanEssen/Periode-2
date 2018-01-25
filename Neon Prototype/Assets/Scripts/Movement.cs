using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 v;
    public float hor;
    public float ver;
    public float speed;

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        v.x = hor;
        v.z = ver;
        transform.Translate(v * speed * Time.deltaTime);
    }
}