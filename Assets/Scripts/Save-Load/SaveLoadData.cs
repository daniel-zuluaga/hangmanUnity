using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadData : MonoBehaviour
{
    private void OnEnable()
    {
        LoadDataInt();
    }

    private void OnDisable()
    {
        SaveDataInt();
    }

    public void SaveDataInt()
    {
        PlayerPrefs.SetInt("MoneyPlayer", InfoPlayer.instanceInfoPlayer.money);
    }

    public void LoadDataInt()
    {
        PlayerPrefs.GetInt("MoneyPlayer", 10);
    }
}
