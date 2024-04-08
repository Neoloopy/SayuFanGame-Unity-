using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    // makes a list of sounds
    public Sounds[] sounds;
    // set the values of each sound
    private void Awake() 
    {
        foreach (Sounds eachSound in sounds)
        {
            eachSound.source = this.gameObject.AddComponent<AudioSource>();
            eachSound.source.clip = eachSound.clip;

            eachSound.source.volume = eachSound.volume;
            eachSound.source.pitch = eachSound.pitch;
        }
    }

    public void Play(string name) {
        Sounds soundSelected = Array.Find(sounds, sound => sound.name == name);
        if(soundSelected == null){ 
            Debug.Log($"{name} does not exist in array. Error NULL");
            return; 
        }
        soundSelected.source.Play();
    }

    public void Stop(string name) {
        Sounds soundSelected = Array.Find(sounds, sound => sound.name == name);
        if(soundSelected == null){ 
            Debug.Log($"{name} does not exist in array. Error NULL");
            return; 
        }
        soundSelected.source.Stop();
    }

    public void PlayLoop(string name) {
        Sounds soundSelected = Array.Find(sounds, sound => sound.name == name);
        if(soundSelected == null){ 
            Debug.Log($"{name} does not exist in array. Error NULL");
            return; 
        }
        soundSelected.source.Play();
        soundSelected.source.loop = true;
    }

    // Setting
    public void ChangeVolume(float value, AudioType type) {
        foreach (Sounds eachSound in sounds) {
            if(eachSound.audioType != type){ continue; }
            eachSound.source.volume = value;
        }
    }

    public void MuteVolume(AudioType type) => ChangeVolume(0, type);
}
