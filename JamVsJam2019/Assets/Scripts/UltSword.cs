using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltSword : MonoBehaviour
{
    [HideInInspector] public bool isSword;
    [HideInInspector] public GameObject player;

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        if(isSword)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
