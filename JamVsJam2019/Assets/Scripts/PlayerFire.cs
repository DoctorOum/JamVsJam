using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    bool isFire;
    public float shootInterval;
    int playerNumber;

    void Start()
    {
        isFire = false;
        playerNumber = GetComponent<PlayerMovement>().playerNumber;
    }
    
    void Update()
    {
        StartCoroutine(InputManager.BButton(playerNumber.ToString()) && !isFire ? Fire() : Empty());
    }
    IEnumerator Empty() { yield return new WaitForSeconds(0); }
    IEnumerator Fire()
    {
        isFire = true;

        GameObject test = Instantiate(bullet, transform.position, transform.rotation);
        test.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        test.tag = tag;

        yield return new WaitForSeconds(shootInterval);
        isFire = false;
    }
}