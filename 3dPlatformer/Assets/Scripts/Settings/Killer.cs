using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Kill")
        {
            
                
                SceneManager.LoadScene("ChoseLVL");
            
        }
;
    }
}
