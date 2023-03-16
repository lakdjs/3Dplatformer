using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinOut : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _coinText;
    void Update()
    {
        _coinText.text = "Coins: " + PlayerPrefs.GetInt("coins",0);
    }
}
