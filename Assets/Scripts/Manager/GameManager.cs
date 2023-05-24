using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instanceGameManager;

    public GameObject[] gameObjectsCheck_X;

    [Header("Ganar Monedas")]
    public int moneyMinGanar = 2;
    public int moneyMaxganar = 7;
    private bool canAddMoney = false;

    public int intentos = 8;

    [Header("Canvas Object")]
    [SerializeField] private GameObject winCanvas;

    private void Awake() => instanceGameManager = this;

    private void Start()
    {
        winCanvas.SetActive(false);
        for (int i = 0; i < gameObjectsCheck_X.Length; i++)
        {
            gameObjectsCheck_X[i].SetActive(false);
        }
    }

    private void Update() => GanastesGameFinish();

    public void GanastesGameFinish()
    {
        var wordContentLetter = WordContentLetter.instanceWordContentLetter;

        if (!wordContentLetter.wordMask.Contains("_"))
        {
            wordContentLetter.wordMask = wordContentLetter.wordAdivinar;
            if(!canAddMoney)
                GanoGame();
        }
    }

    public void GanoGame()
    {
        winCanvas.SetActive(true);
        RandomGanarMonedas(moneyMinGanar, moneyMaxganar);
        canAddMoney = true;
    }

    public void RandomGanarMonedas(int minMoney, int maxMoney)
    {
        int monedasRandom = Random.Range(minMoney, maxMoney);

        int moneyGanada = monedasRandom;
        InfoPlayer.instanceInfoPlayer.AddMoney(moneyGanada);
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
