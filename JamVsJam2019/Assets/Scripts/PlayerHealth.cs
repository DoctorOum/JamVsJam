using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public TMPro.TextMeshProUGUI healthDisplay;
    public int health = 10;
    
    public void Damage()
    {
        health -= 1;
        healthDisplay.text = (100 * health / 25) + "%";
        healthDisplay.gameObject.transform.localScale *= 1.1f;
        Invoke("SizeRestore", .15f);
    }
    void SizeRestore()
    {
        healthDisplay.gameObject.transform.localScale /= 1.1f;
    }
}