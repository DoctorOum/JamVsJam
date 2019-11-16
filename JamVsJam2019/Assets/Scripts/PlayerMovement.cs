using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(1, 2)] public int playerNumber;

    void Update()
    {
        transform.position += (InputManager.MainHorizontal(playerNumber.ToString()) < 0 && transform.position.x > 2 ? Vector3.left : InputManager.MainHorizontal(playerNumber.ToString()) > 0 && transform.position.x < 8 ? Vector3.right : Vector3.zero);
    }
}