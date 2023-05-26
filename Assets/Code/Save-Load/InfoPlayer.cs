using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{
    public static InfoPlayer instanceInfoPlayer;

    public DataPlayer dataPlayer;

    private SaveDataEncriptada saveDataEncriptada;

    private void Awake()
    {
        saveDataEncriptada = new();
        instanceInfoPlayer = this;
    }

    public void AddMoney(int amount) => dataPlayer.playerMoney.money += amount;

    public void Substract(int amount)
    {
        if(dataPlayer.playerMoney.money > amount)
        {
            dataPlayer.playerMoney.money -= amount;
        }
        else
        {
            Debug.Log("No tiene dinero suficiente");
            return;
        }
    }

    private void OnEnable()
    {
        PlayerMoney playerMoney = saveDataEncriptada.LoadData(false);
        dataPlayer.playerMoney.money = playerMoney.money;
        Debug.Log(playerMoney.money);
    }

    private void OnDisable()
    {
        saveDataEncriptada.SaveData(dataPlayer.playerMoney, false);
    }
}
