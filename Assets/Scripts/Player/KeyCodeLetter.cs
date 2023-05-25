using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyCodeLetter : MonoBehaviour
{
    [Header("General")]
    public char letter;
    public int amountFallos;

    [Header("Components")]
    public Button buttonLetter;
    public GameObject objCheckLetter;
    public GameObject objNoCheckLetter;

    private void Start()
    {
        objCheckLetter.SetActive(false);
        objNoCheckLetter.SetActive(false);
    }

    public void ValidarSiExisteLetter()
    {
        if (!WordContentLetter.instanceWordContentLetter.wordAdivinar.Contains(letter))
        {
            GameManager.instanceGameManager.SubstractFallos(amountFallos);
            DesabilitarKeyCodeLetter(objNoCheckLetter);
        }
        string siguienteMostrar = "";

        for (int i = 0; i < WordContentLetter.instanceWordContentLetter.wordAdivinar.Length; i++)
        {
            if (letter == WordContentLetter.instanceWordContentLetter.wordAdivinar[i])
            {
                siguienteMostrar += letter;
                DesabilitarKeyCodeLetter(objCheckLetter);
            }
            else
            {
                siguienteMostrar += WordContentLetter.instanceWordContentLetter.wordMask[i];
            }
        }

        WordContentLetter.instanceWordContentLetter.wordMask = siguienteMostrar;
    }

    public void DesabilitarKeyCodeLetter(GameObject gameObjectLetter)
    {
        gameObjectLetter.SetActive(true);
        buttonLetter.interactable = false;
    }
}
