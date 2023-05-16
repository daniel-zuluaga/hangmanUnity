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
    public List<string> wordsAnimals = new()
    {
        "cocodrilo", "elefante", "foca", "tiburon", "tigre", "pinguino", "gato", "oso gris", "orca", "coati", "conejo", "comadreja",
        "leon marino", "leon", "murcielago", "nutrias", "ornitorrinco", "oso polar", "rinoceronte", "zorro", "perro",
        "oso hormiguero", "mapache", "jaguar", "leopardo", "almiqui", "koala", "diablo de tasmania", "hiena", "llama", "oveja",
        "panda", "topo", "pantera", "vaca", "canguro", "alpaca", "ardilla", "armadillo", "marsopa", "delfin", "cerdo", "ciervo", "ballena",
        "manatin", "morsa", "castor", "beluga", "narval", "cachalote", "hipopotamo", "bontebok", "bosbok", "boto", "bufalo cafre", "bucardo",
        "bufalo de agua", "buey almizclero", "buey", "Caballo Przewalski", "Caballo monchino"
    };

    private void Awake()
    {
        instanceWordContentLetter = this;
    }

    private void Start()
    {
        MaskedWord();
    }

    private void Update()
    {
        textword.text = wordMask;
    }

    public void RandomWord()
    {
        int randomWord = Random.Range(0, wordsAnimals.Count);

        wordAdivinar = wordsAnimals[randomWord];
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
