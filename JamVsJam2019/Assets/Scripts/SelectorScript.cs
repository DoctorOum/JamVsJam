using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorScript : MonoBehaviour
{
    public GameObject RedShip, BlueShip, RedSword, BlueSword;

    private Vector2 CharacterPosition, OffScreen;
    private int CharacterInt = 1;
    private SpriteRenderer RedShipRender, BlueShipRender, RedSwordRender, BlueSwordRender;

    private void Awake()
    {
        CharacterPosition = RedShip.transform.position;
        OffScreen = BlueShip.transform.position;
        RedShipRender = RedShip.GetComponent<SpriteRenderer>();
        BlueShipRender = BlueShip.GetComponent<SpriteRenderer>();
        RedSwordRender = RedSword.GetComponent<SpriteRenderer>();
        BlueSwordRender = BlueSword.GetComponent<SpriteRenderer>();
    }

    public void NextCharacter()
    {
        switch(CharacterInt)
        {
            case 1:
                RedShipRender.enabled = false;
                RedShip.transform.position = OffScreen;
                BlueShip.transform.position = CharacterPosition;
                BlueShipRender.enabled = true;
                CharacterInt++;
                break;
            case 2:
                BlueShipRender.enabled = false;
                BlueShip.transform.position = OffScreen;
                RedSword.transform.position = CharacterPosition;
                RedSwordRender.enabled = true;
                CharacterInt++;
                break;
            case 3:
                RedSwordRender.enabled = false;
                RedSword.transform.position = OffScreen;
                BlueSword.transform.position = CharacterPosition;
                BlueSwordRender.enabled = true;
                CharacterInt++;
                break;
            case 4:
                BlueSwordRender.enabled = false;
                BlueSword.transform.position = OffScreen;
                RedShip.transform.position = CharacterPosition;
                RedShipRender.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void PreviousCharacter()
    {

        switch (CharacterInt)
        {
            case 1:
                RedShipRender.enabled = false;
                RedShip.transform.position = OffScreen;
                BlueSword.transform.position = CharacterPosition;
                BlueSwordRender.enabled = true;
                CharacterInt--;
                ResetInt();
                break;
            case 2:
                BlueShipRender.enabled = false;
                BlueShip.transform.position = OffScreen;
                RedShip.transform.position = CharacterPosition;
                RedShipRender.enabled = true;
                CharacterInt--;
                break;
            case 3:
                RedSwordRender.enabled = false;
                RedSword.transform.position = OffScreen;
                BlueShip.transform.position = CharacterPosition;
                BlueShipRender.enabled = true;
                CharacterInt--;
                break;
            case 4:
                BlueSwordRender.enabled = false;
                BlueSword.transform.position = OffScreen;
                RedSword.transform.position = CharacterPosition;
                RedSwordRender.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (CharacterInt >= 4)
        {
            CharacterInt = 1;
        }
        else
        {
            CharacterInt = 4;
        }
    }
}
