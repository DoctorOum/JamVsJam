using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public TMPro.TextMeshProUGUI healthDisplay;
    public int health = 10;
    int maxHealth;
    private void Start()
    {
        Invoke("hi", .4f);
    }
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void hi()
    {
        maxHealth = health;
    }
    public void Damage()
    {
        health -= 1;
        healthDisplay.text = (100 * health / maxHealth) + "%";
        healthDisplay.gameObject.transform.localScale *= 1.15f;
        Invoke("SizeRestore", .15f);
    }
    void SizeRestore()
    {
        healthDisplay.gameObject.transform.localScale /= 1.15f;
    }
}