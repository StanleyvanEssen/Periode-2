using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject particle;
    public GameObject particle2;
    public WeaponSwitch check;

    // Use this for initialization
    void Start()
    {
        check = GameObject.FindWithTag("MainCamera").GetComponent<WeaponSwitch>();
        check.b = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1000f))
            {
                if (hit.transform.tag == "Sample Text")
                {
                    if (check.b)
                    {
                        GameObject G = Instantiate(particle, hit.point, Quaternion.identity);
                        Destroy(G, 1);
                        hit.transform.gameObject.GetComponent<Health>().LoseHP(1);
                    }
                    else
                    {
                        GameObject G = Instantiate(particle2, hit.point, Quaternion.identity);
                        Destroy(G, 1);
                        hit.transform.gameObject.GetComponent<Health>().LoseHP(1);
                    }
                }
            }
        }
    }
}
