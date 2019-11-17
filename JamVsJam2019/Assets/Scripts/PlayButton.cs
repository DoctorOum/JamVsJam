using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    public Canvas Menu;
    public Canvas Credit;
    private void Update()
    {
        if ((InputManager.BButton("1") || InputManager.BButton("2")) || Input.GetButtonDown("Cancel"))
        {
            GoBack();
        }
        if(Menu.gameObject.activeInHierarchy && Input.GetButtonDown("Quitty"))
        {
            EndGame();
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        Credit.gameObject.SetActive(true);
        Menu.gameObject.SetActive(false);
    }

    public void EndGame()
    {
        Application.Quit();
    }
    public void GoBack()
    {
        Menu.gameObject.SetActive(true);
        Credit.gameObject.SetActive(false);
    }
}
