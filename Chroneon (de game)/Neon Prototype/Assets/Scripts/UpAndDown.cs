using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public Vector3 uad;
    public float count;
    public bool down;

    void Update()
    {
        if (count >= 0.2f)
        {
            down = true;
        }
        if (count <= -0.2f)
        {
            down = false;
        }

        if (down == false)
        {
            count = count + 0.01f;
            transform.Translate(uad);
            uad.z = uad.z + 0.001f;
        }
        else
        {
            count = count - 0.01f;
            transform.Translate(uad);
            uad.z = uad.z - 0.001f;
        }
    }
}