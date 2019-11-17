using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorScript : MonoBehaviour
{
    public GameObject RedShip, BlueShip, RedSword, BlueSword;
    public bool BlueSwordOn, RedSwordOn;

    //private Vector2 CharacterPosition, OffScreen;
    private int CharacterInt1 = 1;
    private int CharacterInt2 = 1;
    //private SpriteRenderer RedShipRender, BlueShipRender, RedSwordRender, BlueSwordRender;

    private void Update()
    {
        if (Input.GetAxis("J_MainHorizontal1") > 0 && BlueSwordOn == false)
        {
            BlueShip.gameObject.SetActive(false);
            BlueSword.gameObject.SetActive(true);
            BlueSwordOn = true;
        }
        if (Input.GetAxis("J_MainHorizontal1") < 0 && BlueSwordOn == true)
        {
            BlueSword.gameObject.SetActive(false);
            BlueShip.gameObject.SetActive(true);
            BlueSwordOn = false;
        }

        if (Input.GetAxis("J_MainHorizontal2") > 0 && RedSwordOn == false)
        {
            RedShip.gameObject.SetActive(false);
            RedSword.gameObject.SetActive(true);
            RedSwordOn = true;
        }
        if (Input.GetAxis("J_MainHorizontal2") < 0 && RedSwordOn == true)
        {
            RedSword.gameObject.SetActive(false);
            RedShip.gameObject.SetActive(true);
            RedSwordOn = false;
        }
    }
    private void Start()
    {
        BlueSwordOn = false;
        RedSwordOn = false;
    }
    public void NextCharacter1()
    {
            switch (CharacterInt1)
            {

                case 1:
                    RedShip.gameObject.SetActive(false);
                    RedSword.gameObject.SetActive(true);
                    CharacterInt1++;
                    break;
                case 2:
                    RedSword.gameObject.SetActive(false);
                    RedShip.gameObject.SetActive(true);
                    CharacterInt1++;
                    ResetInt();
                    break;
                default:
                    ResetInt();
                    break;
            }
    }

    public void PreviousCharacter1()
    {
        if (Input.GetAxis("J_MainHorizontal1") < 0)
        {
            switch (CharacterInt1)
            {
                case 1:
                    RedShip.gameObject.SetActive(true);
                    RedSword.gameObject.SetActive(false);
                    CharacterInt1--;
                    ResetInt();
                    break;
                case 2:
                    RedShip.gameObject.SetActive(false);
                    RedSword.gameObject.SetActive(true);
                    CharacterInt1--;
                    break;
                default:
                    ResetInt();
                    break;
            }
        }
    }

    private void ResetInt()
    {
        if (CharacterInt1 >= 2)
        {
            CharacterInt1 = 1;
        }
        else
        {
            CharacterInt1 = 2;
        }
    }

    public void NextCharacter2()
    {
        if (Input.GetAxis("J_MainHorizontal2") > 0)
        {
            switch (CharacterInt2)
            {
                case 1:
                    BlueShip.gameObject.SetActive(false);
                    BlueSword.gameObject.SetActive(true);
                    CharacterInt2++;
                    break;
                case 2:
                    BlueSword.gameObject.SetActive(false);
                    BlueShip.gameObject.SetActive(true);
                    CharacterInt2++;
                    ResetInt2();
                    break;
                default:
                    ResetInt2();
                    break;
            }
        }
    }

    public void PreviousCharacter2()
    {
        if (Input.GetAxis("J_MainHorizontal2") < 0)
        {
            switch (CharacterInt2)
            {
                case 1:
                    BlueShip.gameObject.SetActive(true);
                    BlueSword.gameObject.SetActive(false);
                    CharacterInt2--;
                    ResetInt2();
                    break;
                case 2:
                    BlueShip.gameObject.SetActive(false);
                    BlueSword.gameObject.SetActive(true);
                    CharacterInt2--;
                    break;
                default:
                    ResetInt2();
                    break;
            }
        }
    }

    private void ResetInt2()
    {
        if (CharacterInt2 >= 2)
        {
            CharacterInt2 = 1;
        }
        else
        {
            CharacterInt2 = 2;
        }
    }
}
