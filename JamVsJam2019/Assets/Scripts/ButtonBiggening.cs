using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBiggening : MonoBehaviour
{
    Button butt;
    bool isBig;
    void Start()
    {
        isBig = false;
        butt = GetComponent<Button>();
    }
    void Update()
    {
        if(!isBig && UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject == gameObject)
        {
            gameObject.transform.localScale *= 1.2f;
            isBig = true;
        }
        if(isBig && UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != gameObject)
        {
            gameObject.transform.localScale /= 1.2f;
            isBig = false;
        }
    }
}