using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayCanvasScript : MonoBehaviour
{

    public GameObject canvasUi;

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
