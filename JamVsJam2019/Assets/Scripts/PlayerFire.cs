using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    bool isFire;
    bool isReload;
    public float shootInterval;
    public int bulletCount;
    int bulletMax;
    int playerNumber;

    void Start()
    {
        isFire = false;
        playerNumber = GetComponent<PlayerMovement>().playerNumber;
        bulletMax = bulletCount;
    }
    void BulletIncrease(int count)
    {
        bulletCount += count;
    }
    void Update()
    {
        StartCoroutine(InputManager.XButton(playerNumber.ToString()) && !isFire && bulletCount > 0 ? Fire() : Empty());
        StartCoroutine(bulletCount <= 0 && !isReload ? Reload() : Empty());
    }
    IEnumerator Empty() { yield return new WaitForSeconds(0); }
    IEnumerator Reload()
    {
        isFire = true;
        isReload = true;

        yield return new WaitForSeconds(2);
        bulletCount = bulletMax;
        isFire = false;
        isReload = false;
    }
    IEnumerator Fire()
    {
        isFire = true;

        GameObject test = Instantiate(bullet, transform.position, transform.rotation);
        test.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        test.tag = tag;
        bulletCount -= 1;

        yield return new WaitForSeconds(shootInterval);
        isFire = false;
    }
}