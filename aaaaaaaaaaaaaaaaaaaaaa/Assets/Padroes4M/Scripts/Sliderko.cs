using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sliderko : MonoBehaviour
{
    private AudioManager audioManager;
    private Slider slider;

    public void Start()
    {
        audioManager = AudioManager.Instance;
        slider = GetComponent<Slider>();

        if (slider != null && audioManager != null)
        {
            slider.value = audioManager.Volume;
            slider.onValueChanged.AddListener(OnSliderValueChanged);
        }
        
        //outraaula
        
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(float sliderValue)
    {
        //env conteudo novo p canal sb volume 
        
        AudioObserverManager.ChangeVolumeSliderValue(sliderValue);
    }

    public void OnSliderValueChanged(float value)
    {
        if (audioManager != null)
        {
            audioManager.Volume = value;
        }
    }
//outra aula
//criador

   [SerializeField] private Slider volumeSlider; 
}
