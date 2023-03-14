using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    private int _coin;

    private void Start()
    {
        _coin = PlayerPrefs.GetInt("coins", 0);
        Debug.Log(_coin);
        Debug.Log(PlayerPrefs.GetInt("coins"));
    }
    
    
    private void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "coin")
        {
            PlayerPrefs.SetInt("coins", _coin + 1);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetInt("coins"));
            
            
        }
    }
   
}
