using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public Vector3 m;
    public Vector3 r;

	void Update ()
    {
        transform.Rotate(r * Time.deltaTime);
        transform.Translate(m * Time.deltaTime);
	}

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {

        }
        else
        {
            if (c.gameObject.tag == "Sample Text")
            {
                c.gameObject.GetComponent<Crystal>().LoseHP(1);
            }
            Destroy(gameObject);
        }
    }
}