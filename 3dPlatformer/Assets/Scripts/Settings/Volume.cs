using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private void Update()
    {
        VolumeManage();
    }
    public void VolumeManage()
    {
        AudioListener.volume = _slider.value;
    }
}
