using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player1, Player2;

    void Update()
    {
        StartCoroutine(Player1 == null ? PlayerWin(Player2) : Player2 == null ? PlayerWin(Player1) : Empty());
    }
    IEnumerator Empty() { yield return new WaitForSeconds(0);  }
    IEnumerator PlayerWin(GameObject winner)
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
