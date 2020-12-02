using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clickingButtonSound;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    public void SoundClickButton()
    {
        audioSource.PlayOneShot(clickingButtonSound);
    }
}