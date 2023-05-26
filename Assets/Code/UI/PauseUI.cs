using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{
    public GameObject buttonPause;
    public GameObject canvasPause;

    private void Start()
    {
        buttonPause.SetActive(true);
        canvasPause.SetActive(false);
    }

    public void PausedGame()
    {
        buttonPause.SetActive(false);
        canvasPause.SetActive(true);
    }

    public void Unpause()
    {
        buttonPause.SetActive(true);
        canvasPause.SetActive(false);
    }
}
