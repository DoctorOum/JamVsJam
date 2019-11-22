using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltSword : MonoBehaviour
{
    [HideInInspector] public bool isSword;
    [HideInInspector] public GameObject player;
    bool hitPlayer = false;
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        if(isSword)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != tag && collision.GetComponent<PlayerHealth>() != null && !hitPlayer)
        {
            Debug.Log(tag);
            Debug.Log(collision.tag);
            StartCoroutine(Hit(collision.gameObject));
        }
    }
    IEnumerator Hit(GameObject hit)
    {
        hitPlayer = true;
        hit.GetComponent<PlayerHealth>().Damage();
        yield return new WaitForSeconds(.34f);
        hitPlayer = false;
    }
}