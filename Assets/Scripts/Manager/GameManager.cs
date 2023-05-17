using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instanceGameManager;

    public int intentos = 8;
    public bool terminado = false;

    [Header("Canvas Object")]
    [SerializeField] private GameObject winCanvas;

    private void Awake()
    {
        instanceGameManager = this;
        winCanvas.SetActive(false);
    }

    private void Update()
    {
        GanastesGameFinish();
    }

    public void GanastesGameFinish()
    {
        var wordContentLetter = WordContentLetter.instanceWordContentLetter;

        if (!wordContentLetter.wordMask.Contains("_"))
        {
            wordContentLetter.wordMask = wordContentLetter.wordAdivinar;
            winCanvas.SetActive(true);
        }
    }

    public void SubstractFallos(int amount)
    {
        if (intentos >= 0)
        {
            intentos -= amount;
        }
        else
        {
            intentos = 0;
        }
    }
}
