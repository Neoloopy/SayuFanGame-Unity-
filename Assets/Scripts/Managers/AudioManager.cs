using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    // makes a list of sounds
    public Sounds[] sounds;
    Sounds soundSelected;
    // set the values of each sound
    private void Awake()
    {
        foreach (Sounds eachSound in sounds)
        {
            eachSound.source = this.gameObject.AddComponent<AudioSource>();
            eachSound.source.clip = eachSound.clip;

            eachSound.source.volume = eachSound.volume;
            eachSound.source.pitch = eachSound.pitch;
            if (eachSound.canLoop) { soundSelected.source.loop = true; }
        }
    }

    /// <summary>
    /// Finds the song in an array and checks if it should play the song or stop it
    /// </summary>
    /// <param name="name"></param>
    /// <param name="shouldPlay"></param>
    public void MethodCaller(string name, bool shouldPlay)
    {
        soundSelected = Array.Find(sounds, sound => sound.name == name);
        if (soundSelected == null)
        {
            Debug.Log($"{name} does not exist in array. Error NULL");
            return;
        }

        if (shouldPlay)
            soundSelected.source.Play();
        else
            soundSelected.source.Stop();

        soundSelected = null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="From"></param>
    /// <param name="To"></param>
    public void ChangeAudio(string From, string To)
    {
        MethodCaller(From, false);
        MethodCaller(To, true);
    }

    // Volume Settings =====

    /// <summary>
    /// Changes the Volume of each audio
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    public void ChangeVolume(float value, AudioType type)
    {
        foreach (Sounds eachSound in sounds)
        {
            if (eachSound.audioType != type) { continue; }
            eachSound.source.volume = value;
        }
    }
    /// <summary>
    /// Mutes each volume to the value of 0
    /// </summary>
    /// <param name="type"></param>
    public void MuteVolume(AudioType type) => ChangeVolume(0, type);
}
