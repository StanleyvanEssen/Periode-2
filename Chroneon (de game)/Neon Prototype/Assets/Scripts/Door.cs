using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 r;
    public Crystal check;
    public float timer;
    public float speed;
    public bool open;
    public bool alive;

    void Update()
    {
        if (check.hp <= 0)
        {
            open = true;
        }
        if (open && alive)
        {
            timer += Time.deltaTime;
            transform.Rotate(r * Time.deltaTime * speed);
            if(timer >= 3)
            {
                alive = false;
            }
        }
    }
}