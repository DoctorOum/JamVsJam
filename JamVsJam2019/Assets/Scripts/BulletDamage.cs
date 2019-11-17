using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int health;

    void Start()
    {
        health = Random.Range(2, 4) + health;
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
                GetComponent<AudioSource>().Play();
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<SpriteRenderer>().enabled = false;
                Destroy(health > 0 ? collision.gameObject : gameObject, GetComponent<AudioSource>().clip.length);
            }
            else
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<SpriteRenderer>().enabled = false;
                Destroy(gameObject, GetComponent<AudioSource>().clip.length);
            }
        }
    }
    public void Damage()
    {
        health -= 1;
    }
}