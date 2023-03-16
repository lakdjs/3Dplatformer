using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coins : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;


    void Update()
    {
        _coinText.text = "Your coins: " + PlayerPrefs.GetInt("coins"); 
    }
}
