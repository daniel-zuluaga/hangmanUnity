using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateTextMesh : MonoBehaviour
{
    public TextMeshProUGUI textMoney;

    private void Update()
    {
        UpdateTextMoney();
    }

    private void UpdateTextMoney()
    {
        textMoney.text = "$ " + InfoPlayer.instanceInfoPlayer.dataPlayer.playerMoney.money.ToString();
    }
}
