using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(1, 2)] public int playerNumber;
    bool isMove;

    void Start()
    {
        isMove = false;
    }
    
    void Update()
    {
        if(playerNumber == 1 && !isMove)
        {
            if(Input.GetKey(KeyCode.A) && transform.position.x > 2)
            {
                StartCoroutine(UpdatePosition(Vector3.left));
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 8)
            {
                StartCoroutine(UpdatePosition(Vector3.right));
            }
        }
        else if(playerNumber == 2 && !isMove)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 2)
            {
                StartCoroutine(UpdatePosition(Vector3.left));
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8)
            {
                StartCoroutine(UpdatePosition(Vector3.right));
            }
        }
    }
    IEnumerator UpdatePosition(Vector3 addPosition)
    {
        isMove = true;

        transform.position += addPosition;

        yield return new WaitForSeconds(.125f);
        isMove = false;
    }
}