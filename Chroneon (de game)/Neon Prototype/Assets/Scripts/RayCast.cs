using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject particle;
    public GameObject particle2;
    public WeaponSwitch checkWS;
    public GameObject bullet1;
    public GameObject bullet2;
    public Transform barrel;
    public Transform barrel2;

    void Start()
    {
        checkWS = GameObject.FindWithTag("MainCamera").GetComponent<WeaponSwitch>();
        checkWS.b = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (checkWS.b)
            {
                GameObject G = Instantiate(bullet1, barrel.transform.position, barrel.transform.rotation);
                Destroy(G, 10);
            }
            else
            {
                GameObject G = Instantiate(bullet2, barrel2.transform.position, barrel2.transform.rotation);
                Destroy(G, 10);
            }
        }
    }
}