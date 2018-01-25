using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator : MonoBehaviour
{
    public Vector3 v;
    public float hor;
    public float ver;
    public float speed;
    public Vector3 v2;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Cursor.visible = false;
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        v.x = hor;
        v.y = ver;
        transform.Translate(v * speed * Time.deltaTime);
        v2.y = Input.GetAxis("Mouse X");
        transform.Rotate(v2);
    }
}