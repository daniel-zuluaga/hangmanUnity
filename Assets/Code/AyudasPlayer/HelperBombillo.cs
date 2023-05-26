using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelperBombillo : MonoBehaviour
{
    public static HelperBombillo instanceHelperBombillo;

    public int costValueHelper = 10;
    public KeyCodeLetter[] keyCodeLetters;
    public List<char> listStringLetter = new();

    public bool volverAdd = false;

    public char letterSelect;

    public TextMeshProUGUI textBombilloValue;

    private void Awake()
    {
        instanceHelperBombillo = this;
    }

    private void Update()
    {
        textBombilloValue.text = $"$ {costValueHelper}";
    }

    public void UseBombilloHelperOneLetter()
    {

        if (!volverAdd)
        {
            for (int i = 0; i < WordContentLetter.instanceWordContentLetter.wordAdivinar.Length; i++)
            {
                if (WordContentLetter.instanceWordContentLetter.wordAdivinar[i] != ' ')
                {
                    listStringLetter.Add(WordContentLetter.instanceWordContentLetter.wordAdivinar[i]);
                }
            }
        }
        InfoPlayer.instanceInfoPlayer.Substract(costValueHelper);

        int randomLetter = Random.Range(0, listStringLetter.Count);

        letterSelect = listStringLetter[randomLetter];

        for (int i = 0; i < keyCodeLetters.Length; i++)
        {
            KeyCodeLetter keyCode = keyCodeLetters[i];

            if (keyCode.letter == letterSelect)
            {
                keyCode.AyudarPlayerWithLetterCheck(letterSelect);
                volverAdd = true;
            }
        }
    }
}
