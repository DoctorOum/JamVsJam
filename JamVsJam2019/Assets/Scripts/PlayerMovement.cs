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
        if (InputManager.MainHorizontal(playerNumber.ToString()) < 0 && transform.position.x > 2)
        {
            transform.position += Vector3.left;
        }
        if (InputManager.MainHorizontal(playerNumber.ToString()) > 0 && transform.position.x < 8)
        {
            transform.position += Vector3.right;
        }
        /*if (playerNumber == 1 && !isMove)
        {
            if(Input.GetKey(KeyCode.A) && transform.position.x > 2)
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 8)
            {
                transform.position += Vector3.right;
            }
        }
        else if(playerNumber == 2 && !isMove)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 2)
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8)
            {
                transform.position += Vector3.right;
            }
        }*/
    }
}