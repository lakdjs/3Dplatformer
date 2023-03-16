using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Teleport")
        {
            UnLockLevel();
            SceneManager.LoadScene("ChoseLVL");
        }
    }


    public void UnLockLevel()
    {
        int currentLevel = (SceneManager.GetActiveScene().buildIndex) - 2;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }
}
