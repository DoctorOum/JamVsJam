using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int health;

    void Start()
    {
        health = Random.Range(2, 4);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != tag)
        {
            if (collision.GetComponent<BulletDamage>() != null)
            {
                while (health > 0 && collision.GetComponent<BulletDamage>().health > 0)
                {
                    collision.GetComponent<BulletDamage>().Damage();
                    Damage();
                }
                Destroy(health > 0 ? collision.gameObject : gameObject);
            }
            else if(collision.GetComponent<PlayerHealth>() != null)
            {
                while (health > 0 && collision.GetComponent<PlayerHealth>().health > 0)
                {
                    collision.GetComponent<PlayerHealth>().Damage();
                    Damage();
                }
                Destroy(health > 0 ? collision.gameObject : gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    public void Damage()
    {
        health -= 1;
    }
}