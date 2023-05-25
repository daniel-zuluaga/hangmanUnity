using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelperBombillo : MonoBehaviour
{
    public float costValueHelper = 10;
    public KeyCodeLetter[] keyCodeLetters;
    public List<char> listStringLetter = new();

    public char letterSelect;

    public TextMeshProUGUI textBombilloValue;

    public void UseBombilloHelperOneLetter()
    {
        for (int i = 0; i < WordContentLetter.instanceWordContentLetter.wordAdivinar.Length; i++)
        {
            listStringLetter.Add(WordContentLetter.instanceWordContentLetter.wordAdivinar[i]);
        }

        int randomLetter = Random.Range(0, listStringLetter.Count);

        letterSelect = listStringLetter[randomLetter];

        for (int i = 0; i < keyCodeLetters.Length; i++)
        {
            KeyCodeLetter keyCode = keyCodeLetters[i];

            if (keyCode.letter == letterSelect)
            {
                keyCode.DesabilitarKeyCodeLetter(keyCode.objCheckLetter);
            }
        }
    }
}
