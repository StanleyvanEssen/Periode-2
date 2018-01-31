using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject endScreen;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        endScreen.SetActive(false);
    }

    void OnCollisionEnter(Collision c)
    {
        endScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}