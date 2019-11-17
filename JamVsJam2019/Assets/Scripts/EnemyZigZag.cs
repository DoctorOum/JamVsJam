using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZigZag : MonoBehaviour
{
    public int zigZagInterval = 1;
    int coefficient = 1;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        switch(Random.Range(1, 3))
        {
            case 1:
                coefficient = -1;
                break;
            case 2:
            default:
                coefficient = 1;
                break;
        }
        rb.velocity += Vector2.right * coefficient * .5f;
        InvokeRepeating("SwitchCoefficient", 0, zigZagInterval);
    }
    void SwitchCoefficient()
    {
        coefficient = -coefficient;
        rb.velocity += Vector2.right * coefficient * 1f;
    }
}