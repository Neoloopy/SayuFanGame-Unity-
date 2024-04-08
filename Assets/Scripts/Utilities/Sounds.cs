using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sounds 
{
    public string name;

    public AudioType audioType;
    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;
    [Range(0.1f,3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}

public enum AudioType {
    BGM, 
    SFX
}