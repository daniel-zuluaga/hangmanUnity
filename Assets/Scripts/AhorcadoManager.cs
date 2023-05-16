using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AhorcadoManager : MonoBehaviour
{
    public GameObject[] imageHangman;

    private void Start()
    {
        for (int i = 0; i < imageHangman.Length; i++)
        {
            imageHangman[i].SetActive(false);
        }
    }

    private void Update()
    {
        SwitchMuñecoFallos();
    }

    public void SwitchMuñecoFallos()
    {
        switch (GameManager.instanceGameManager.intentos)
        {
            case 7:
                imageHangman[0].SetActive(true);
                break;
            case 6:
                imageHangman[1].SetActive(true);
                break;
            case 5:
                imageHangman[2].SetActive(true);
                break;
            case 4:
                imageHangman[3].SetActive(true);
                break;
            case 3:
                imageHangman[4].SetActive(true);
                break;
            case 2:
                imageHangman[5].SetActive(true);
                break;
            case 1:
                imageHangman[6].SetActive(true);
                break;
            case 0:
                imageHangman[7].SetActive(true);
                Debug.Log("Perdistes");
                SceneManager.LoadScene("Game");
                break;
        }
    }
}
