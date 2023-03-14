using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private int KeyNum;
    private void Start()
    {
        KeyNum = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Key")
        {
            KeyNum = 1;
        }
    }
}
