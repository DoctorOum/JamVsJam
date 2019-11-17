using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Quitty"))
        {
            Application.Quit();
        }
    }
}
