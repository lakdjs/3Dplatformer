using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVL1 : MonoBehaviour
{
   
    void Start()
    {
        PlayerPrefs.SetInt("levels", 1);
        Debug.Log(PlayerPrefs.GetInt("levels"));
    }

}
