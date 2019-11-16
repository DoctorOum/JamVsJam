using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputManager : MonoBehaviour
{
    void Update()
    {
        if (InputManager.AButton())
        {
            Debug.Log(InputManager.MainJoystick());
        }
    }
}
