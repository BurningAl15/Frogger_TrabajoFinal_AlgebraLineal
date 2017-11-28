using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

    public static soundManager instance;

    public AudioClip jump;
    public AudioClip death;
    public AudioSource audioSource;

    void Awake()
    {
        if (soundManager.instance == null)
        {
            soundManager.instance = this;
        }
        else if (soundManager.instance != this)
        {
            Destroy(gameObject);
        }
     
    }

    public void Jump()
    {
        PlayAudioClip(jump);
    }

    public void Death()
    {
        PlayAudioClip(death);
    }

    private void PlayAudioClip(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
