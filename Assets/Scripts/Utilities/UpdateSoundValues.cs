using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UpdateSoundValues : MonoBehaviour
{
    [SerializeField] TMP_InputField _textbox;
    [SerializeField] Slider _slider;
    [SerializeField] AudioType audioType;
    [SerializeField] private AudioManager audioManager;
    private void Start(){
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    } 
    public void OnClick(){
        audioManager.ChangeVolume(_slider.value, audioType);
        _textbox.text = ((int)(_slider.value * 100f)).ToString() + "%";
    }
}
