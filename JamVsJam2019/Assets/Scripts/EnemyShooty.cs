using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooty : MonoBehaviour
{
    public GameObject bullet;
    public int playerNumber;

    void Start()
    {
        InvokeRepeating("Shoot", 3, 4);
    }
    void Shoot()
    {
        GameObject test = Instantiate(bullet, transform.position, transform.rotation);
        test.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        test.tag = tag;
    }
}