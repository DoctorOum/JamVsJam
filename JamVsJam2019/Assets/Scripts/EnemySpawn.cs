using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] Enemies;
    int playerNumber;
    bool spawningY;
    void Start()
    {
        spawningY = false;
        playerNumber = GetComponent<PlayerMovement>().playerNumber;
    }

    void Update()
    {
        if(InputManager.YButton(playerNumber.ToString()) && !spawningY)
        {
            StartCoroutine(SpawnY());
        }
    }
    IEnumerator SpawnY()
    {
        spawningY = true;

        GameObject temp;
        temp = Instantiate(Enemies[2], transform.position + new Vector3(-2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(-1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(0f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));
        temp = Instantiate(Enemies[2], transform.position + new Vector3(2f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI)), 1.5f * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI))), transform.rotation);
        temp.tag = tag;
        temp.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8 * -Mathf.Round(Mathf.Cos(playerNumber * Mathf.PI));

        yield return new WaitForSeconds(8);
        spawningY = false;
    }
}
