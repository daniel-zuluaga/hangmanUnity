using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarPalabraUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textWordMostrar;

    private void Update()
    {
        textWordMostrar.text = WordContentLetter.instanceWordContentLetter.wordAdivinar;
    }
}
