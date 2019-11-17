using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorScript : MonoBehaviour
{
    public GameObject RedShip, BlueShip, RedSword, BlueSword;
    public bool BlueSwordOn, RedSwordOn, BlueSwordChoose, RedSwordChoose;
    public bool playerSelected1, playerSelected2;
    bool loaded;
    private GameObject BlueSelection, RedSelection;


    //private Vector2 CharacterPosition, OffScreen;
    private int CharacterInt1 = 1;
    private int CharacterInt2 = 1;
    //private SpriteRenderer RedShipRender, BlueShipRender, RedSwordRender, BlueSwordRender;

    private void Update()
    {
        if (!playerSelected1)
        {
            if (Input.GetAxis("J_MainHorizontal1") > 0 && BlueSwordOn == false)
            {
                BlueShip.gameObject.SetActive(false);
                BlueSword.gameObject.SetActive(true);
                BlueSwordOn = true;
                BlueSwordChoose = true;

            }
            else if (Input.GetAxis("J_MainHorizontal1") < 0 && BlueSwordOn == true)
            {
                BlueSword.gameObject.SetActive(false);
                BlueShip.gameObject.SetActive(true);
                BlueSwordOn = false;
                BlueSwordChoose = false;
            }
        }
        if (!playerSelected2)
        {
            if (Input.GetAxis("J_MainHorizontal2") > 0 && RedSwordOn == false)
            {
                RedShip.gameObject.SetActive(false);
                RedSword.gameObject.SetActive(true);
                RedSwordOn = true;
                RedSwordChoose = true;
            }
            else if (Input.GetAxis("J_MainHorizontal2") < 0 && RedSwordOn == true)
            {
                RedSword.gameObject.SetActive(false);
                RedShip.gameObject.SetActive(true);
                RedSwordOn = false;
                RedSwordChoose = false;
            }
        }

        if (Input.GetButtonDown("A_Button1"))
        {
            ChooseBlue();
        }

        if (Input.GetButtonDown("A_Button2"))
        {
            ChooseRed();
        }

        if (!loaded && playerSelected1 == true && playerSelected2 == true)
        {
            loaded = true;
            StartCoroutine(LoadYourAsyncScene());

        }
    }
    private void Start()
    {
        BlueSwordChoose = false;
        RedSwordChoose = false;
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

    public void PreviousCharacter2()
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

    public void ChooseBlue()
    {
        if (!playerSelected1)
        {
            if (BlueSwordChoose == true)
            {
                BlueSelection = BlueSword;
                playerSelected1 = true;
            }
            else
            {
                BlueSelection = BlueShip;
                playerSelected1 = true;
            }
        }
    }
    public void ChooseRed()
    {
        if (!playerSelected2)
        {
            if (RedSwordChoose == true)
            {
                RedSelection = RedSword;
                playerSelected2 = true;
            }
            else
            {
                RedSelection = RedShip;
                playerSelected2 = true;
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

    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        RedSelection.transform.parent = null;
        BlueSelection.transform.parent = null;

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("TristanTestScene", LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            Debug.Log("Loading...");
            yield return null;
        }
        Debug.Log("Loading Finished");
        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(RedSelection, SceneManager.GetSceneByName("TristanTestScene"));
        SceneManager.MoveGameObjectToScene(BlueSelection, SceneManager.GetSceneByName("TristanTestScene"));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }
}