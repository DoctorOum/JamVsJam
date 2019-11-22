using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject ultSword;
    public GameObject ultShield;
    int playerNumber;
    bool spawningY;
    bool spawningA;
    bool spawningB;
    bool spawningUlt;
    public TMPro.TextMeshProUGUI y, a, b, u;

    void Start()
    {
        spawningY = false;
        spawningA = false;
        spawningB = false;
        spawningUlt = true;
        playerNumber = GetComponent<PlayerMovement>().playerNumber;
        StartCoroutine(UltInit());
    }

    void Update()
    {
        if(InputManager.YButton(playerNumber.ToString()) && !spawningY)
        {
            StartCoroutine(SpawnY());
        }
        if(InputManager.AButton(playerNumber.ToString()) && !spawningA)
        {
            StartCoroutine(SpawnA());
        }
        if (InputManager.BButton(playerNumber.ToString()) && !spawningB)
        {
            StartCoroutine(SpawnB());
        }
        if(InputManager.RTrigger(playerNumber.ToString()) && !spawningUlt) 
        {
            StartCoroutine(SpawnUlt());
        }
    }
    IEnumerator Timer(int seconds, TMPro.TextMeshProUGUI text)
    {
        text.text = seconds.ToString();
        yield return new WaitForSeconds(1);
        if (seconds > 1)
        {
            StartCoroutine(Timer(seconds - 1, text));
        }
        else
        {
            text.gameObject.SetActive(false);
        }
    }
    IEnumerator UltInit()
    {
        u.gameObject.SetActive(true);
        StartCoroutine(Timer(60, u));
        yield return new WaitForSeconds(60);
        spawningUlt = false;
    }
    IEnumerator SpawnUlt()
    {
        spawningUlt = true;

        GameObject temp = Instantiate(gameObject.GetComponent<PlayerSetup>().isSword ? ultSword : ultShield, (gameObject.GetComponent<PlayerSetup>().isSword ? ultSword.transform.position : ultShield.transform.position) + Vector3.right * (gameObject.GetComponent<PlayerSetup>().isSword ? transform.position.x : 0), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<UltSword>().isSword = gameObject.GetComponent<PlayerSetup>().isSword;
        temp.GetComponent<UltSword>().player = gameObject;
        u.gameObject.SetActive(true);
        StartCoroutine(Timer(60, u));
        yield return new WaitForSeconds(60);
        spawningUlt = false;
    }
    IEnumerator SpawnA()
    {
        spawningA = true;

        GameObject temp;
        temp = Instantiate(Enemies[0], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(-1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));

        a.gameObject.SetActive(true);
        StartCoroutine(Timer(16, a));
        yield return new WaitForSeconds(16);
        spawningA = false;
    }
    IEnumerator SpawnY()
    {
        spawningY = true;

        GameObject temp;
        temp = Instantiate(Enemies[1], transform.position + new Vector3(-1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 3f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));

        y.gameObject.SetActive(true);
        StartCoroutine(Timer(6, y));
        yield return new WaitForSeconds(6);
        spawningY = false;
    }
    IEnumerator SpawnB()
    {
        spawningB = true;

        GameObject temp;
        temp = Instantiate(Enemies[2], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 4f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 4f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));

        b.gameObject.SetActive(true);
        StartCoroutine(Timer(10, b));
        yield return new WaitForSeconds(10);
        spawningB = false;
    }
    private void OnDestroy()
    {
        GameObject temp;
        
        temp = Instantiate(Enemies[2], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 4f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 4f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1.5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(-1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 3f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[1], transform.position + new Vector3(1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 2 * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(-1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[0], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * .5f * 2 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
    }
}