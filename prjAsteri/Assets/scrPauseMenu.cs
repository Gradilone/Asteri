using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrPauseMenu : MonoBehaviour
{
    public static bool jogoPausado = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (jogoPausado)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Continuar()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        jogoPausado = false; 

    }

    void Pausar()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        jogoPausado = true;

    }

    public void CarregaMenu()
    {

    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();

    }
}
