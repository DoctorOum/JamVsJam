using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    
    public void Damage()
    {
        health -= 1;
    }
}