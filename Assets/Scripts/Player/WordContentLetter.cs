using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordContentLetter : MonoBehaviour
{
    public static WordContentLetter instanceWordContentLetter;

    public string wordAdivinar;
    public string wordMask;
    public TextMeshProUGUI textword;
    private List<string> wordsAnimals = new()
    {
        "Cocodrilo", "Elefante", "Foca", "Tiburon", "Tigre", "pinguino", "gato", "oso gris", "orca", "coati", "conejo", "comadreja",
        "leon marino", "leon", "murcielago", "nutrias", "ornitorrinco", "oso polar", "rinoceronte", "zorro", "perro",
        "oso Hormiguero", "Mapache", "jaguar", "leopardo", "almiqui", "koala", "diablo de tasmania", "hiena", "llama", "oveja",
        "panda", "topo", "pantera", "Vaca", "canguro", "alpaca", "ardilla", "armadillo", "marsopa", "delfin", "cerdo", "ciervo", "ballena",
        "manatin", "morsa", "castor", "beluga", "narval", "cachalote", "hipopotamo", "bontebok", "bosbok", "Pez boto", "bufalo cafre", "bucardo",
        "bufalo de agua", "buey almizclero", "buey", "Caballo przewalski", "Caballo monchino"
    };

    private void Awake() => instanceWordContentLetter = this;

    private void Start() => MaskedWord();

    private void Update() => textword.text = wordMask;

    public void RandomWord()
    {
        int randomWord = Random.Range(0, wordsAnimals.Count);

        wordAdivinar = wordsAnimals[randomWord];

        wordAdivinar = wordAdivinar.ToLower();
    }

    public void MaskedWord()
    {
        RandomWord();
        textword.text = string.Empty;

        for (int i = 0; i < wordAdivinar.Length; i++)
        {
            if (wordAdivinar[i] == ' ')
            {
                wordMask += " ";
            }
            else
            {
                wordMask += "_";
            }

            textword.text = wordMask;
        }
    }
}
