using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject particle;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.magenta);
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1000f))
            {
                if (hit.transform.tag == "Sample Text")
                {
                    print("Xander is toxic");
                    GameObject G = Instantiate(particle, hit.point, Quaternion.identity);
                    Destroy(G, 1);
                    hit.transform.gameObject.GetComponent<Health>().LoseHP(1);
                }
            }
        }
    }
}
