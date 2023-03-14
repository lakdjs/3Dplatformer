using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    int PrefsOld;
    int PrefsNew;
    void Start()
    {
        PrefsOld = PlayerPrefs.GetInt("coins", 0);
        Debug.Log(PrefsOld);
    }

    // Update is called once per frame
    void Update()
    {
        PrefsNew = PlayerPrefs.GetInt("coins", 0);
        Debug.Log(PrefsNew);
        if(PrefsNew>PrefsOld)
        {
            Debug.Log("destroy");
            Destroy(_gameObject);
        }
    }
}
