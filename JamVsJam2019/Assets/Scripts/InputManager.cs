using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    // Axis
    public static float MainHorizontal(string playerNumber)
    {
        float r = 0.0f;
        r += Input.GetAxis("J_MainHorizontal" + playerNumber);
        r += Input.GetAxis("K_MainHorizontal" + playerNumber);
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static float MainVertical()
    {
        float r = 0.0f;
        r += Input.GetAxis("J_MainVertical");
        r += Input.GetAxis("K_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    /*public static Vector2 MainJoystick()
    {
        return new Vector2(MainHorizontal(), MainVertical());
    }*/
  
    // Buttons
    public static bool AButton()
    {
        return Input.GetButtonDown("A_Button");
    }

    public static bool BButton(string playerNumber)
    {
        return Input.GetButton("B_Button" + playerNumber);
    }

    public static bool XButton()
    {
        return Input.GetButtonDown("X_Button");
    }

    public static bool YButton()
    {
        return Input.GetButtonDown("Y_Button");
    }
}
