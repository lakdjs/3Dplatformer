using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoseScene : MonoBehaviour
{
    [SerializeField] private Button _buttonPlay;
    [SerializeField] private Button _buttonChose;
    [SerializeField] private Button _buttonSettings;
    [SerializeField] private Button _buttonQuit;
    [SerializeField] private Button _buttonTutor;
    public void ManageScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Quiting()
    {
        Application.Quit();
    }

}
