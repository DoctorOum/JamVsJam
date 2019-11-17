using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] Enemies;
    int playerNumber;
    bool spawningY;
    bool spawningA;
    bool spawningB;
    public TMPro.TextMeshProUGUI y, a, b;

    void Start()
    {
        spawningY = false;
        spawningA = false;
        spawningB = false;
        playerNumber = GetComponent<PlayerMovement>().playerNumber;
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
    }
}