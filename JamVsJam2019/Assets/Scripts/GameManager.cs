using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player1, Player2;
    public UnityEngine.UI.Text timer;
    public UnityEngine.UI.Image win1, win2, draw;
    int timeClock = 5;
    bool isTime = false;

    void Update()
    {
        StartCoroutine(Player1 == null ? PlayerWin(Player2) : Player2 == null ? PlayerWin(Player1) : Empty());
    }
    IEnumerator Empty() { yield return new WaitForSeconds(0);  }
    IEnumerator PlayerWin(GameObject winner)
    {
        if (!isTime)
        {
            isTime = true;
            timer.gameObject.SetActive(true);
            StartCoroutine(Timer());
            yield return new WaitForSeconds(10);
            SceneManager.LoadScene(0);
        }
    }
    IEnumerator Timer()
    {
        timer.text = timeClock.ToString();
        timeClock -= 1;
        yield return new WaitForSeconds(1);
        if (timeClock > 0)
        {
            StartCoroutine(Timer());
        }
        else
        {
            timer.gameObject.SetActive(false);
            if(Player1 != null)
            {
                win1.gameObject.SetActive(true);
            }
            else if(Player2 != null)
            {
                win2.gameObject.SetActive(true);
            }
            else
            {
                draw.gameObject.SetActive(true);
            }
        }
    }
}