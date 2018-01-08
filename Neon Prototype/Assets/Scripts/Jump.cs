using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody r;
    public Vector3 v;
    public int mayJump;

    // Use this for initialization
    void Start ()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mayJump >= 1)
        {

            if (Input.GetButtonDown("Jump"))
            {
                r.velocity = v;
                mayJump = mayJump - 1;
            }
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (gameObject)
        {
            mayJump = 2;
        }
    }
}
