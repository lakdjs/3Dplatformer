using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clipSelect;
    [SerializeField] private AudioClip _clipiEnter;

    public void SelectSound()
    {
        _audioSource.PlayOneShot(_clipSelect);
    }
    public void EnterSound()
    {
        _audioSource.PlayOneShot(_clipiEnter);
    }
}
