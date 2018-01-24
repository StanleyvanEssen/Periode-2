using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public Light l;
    public Material Material1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoseHP(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            gameObject.GetComponent<Renderer>().material = Material1;
            Destroy(l);
        }
    }
}
