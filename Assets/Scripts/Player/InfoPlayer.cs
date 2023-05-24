using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{
    public static InfoPlayer instanceInfoPlayer;

    public int money;

    private void Awake()
    {
        instanceInfoPlayer = this;
    }

    public void AddMoney(int amount) => money += amount;


    public void LoadData()
    {
        money = PlayerPrefs.GetInt("MoneyPlayer");
    }
}
