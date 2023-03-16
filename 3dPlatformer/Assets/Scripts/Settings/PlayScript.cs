using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScript : MonoBehaviour
{
    [SerializeField] private Button _play;
    public void Update()
    {
        int lvl = PlayerPrefs.GetInt("levels");
        if(lvl > 3)
        {
            SceneManager.LoadScene("Level3");
        }
        else
        {
            SceneManager.LoadScene("Level" + lvl.ToString());
        }
    }
}
