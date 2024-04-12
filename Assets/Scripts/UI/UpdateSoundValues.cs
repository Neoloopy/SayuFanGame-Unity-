using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UpdateSoundValues : MonoBehaviour, IInteractable
{
    [SerializeField] TMP_InputField _textbox;
    [SerializeField] Slider _slider;
    [SerializeField] AudioType _audioType;
    [SerializeField] AudioManager _audioManager;
    private void Start()
    {
        if (_audioManager != null) { return; }
        _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }
    public void OnClick() => ChangeVolume();
    /// <summary>
    /// Changes the volume based on slider values
    /// </summary>
    void ChangeVolume()
    {
        _audioManager.ChangeVolume(_slider.value, _audioType);
        _textbox.text = ((int)(_slider.value * 100f)).ToString() + "%";
    }
}
