using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    GameObject sword, shield;

    void Start()
    {
        Invoke("Setup", .25f);
    }
    void Setup()
    {
        if(GameObject.Find("Sword" + GetComponent<PlayerMovement>().playerNumber))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}