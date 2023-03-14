using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("levels", 1);
        
    }

    
}
