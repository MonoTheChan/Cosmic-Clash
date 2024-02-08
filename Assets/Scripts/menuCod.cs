using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCod : MonoBehaviour
{
    string cena;
    public void ChangeScene(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Fechou o Jogo");
    }
}
