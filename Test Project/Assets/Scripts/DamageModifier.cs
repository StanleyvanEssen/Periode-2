using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageModifier : MonoBehaviour
{
    public float endDamage;
    public float fireModifier;

	// Use this for initialization
	void Start ()
    {
        fireModifier = 1.06f;
        endDamage = Damage(100);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public float Damage (float standardDamage)
    {
        return standardDamage * fireModifier;
    }
}
