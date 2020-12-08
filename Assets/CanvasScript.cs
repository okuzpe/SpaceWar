using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    // Start is called before the first frame update

    public void ShowCanvasPause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void HideCanvasPause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
