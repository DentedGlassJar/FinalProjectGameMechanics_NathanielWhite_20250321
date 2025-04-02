using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource themeMusic;

    private void Start()
    {
        themeMusic.Play();     
    }
}
