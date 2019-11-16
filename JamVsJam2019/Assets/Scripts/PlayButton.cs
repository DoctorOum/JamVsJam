using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    public Canvas Menu;
    public Canvas Credit;

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
}
