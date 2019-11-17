using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooty : MonoBehaviour
{
    public GameObject bullet;
    public int playerNumber;

    void Start()
    {
        InvokeRepeating("Shoot", Random.Range(1f, 2f), Random.Range(2f, 4f));
    }
    void Shoot()
    {
        GameObject test = Instantiate(bullet, transform.position, transform.rotation);
        test.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        test.tag = tag;
        GetComponent<AudioSource>().Play();
    }
}