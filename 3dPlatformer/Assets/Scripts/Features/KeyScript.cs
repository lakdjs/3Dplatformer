using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private GameObject _imageKey;
    [SerializeField] private GameObject _key;
    private int KeyNum;
    private void Start()
    {
        KeyNum = 0;
    }
    private void Update()
    {
        Debug.Log(KeyNum);
        if(KeyNum == 1)
        {
            _imageKey.SetActive(true);
        }
        else
        {
            _imageKey.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Key")
        {
            Debug.Log("Essssss");
            KeyNum = 1;
            Destroy(_key);
        }
    }
}
