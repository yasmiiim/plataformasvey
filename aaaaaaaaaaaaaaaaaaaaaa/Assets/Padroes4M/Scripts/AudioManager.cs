using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    
    public static AudioManager Instance
    {
        get
        {
            return instance;
        }
    }

    public float volume = 0.5f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float Volume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = Mathf.Clamp01(value);
        }
    }

    private void OnEnable()
    {
        //inscreve no canal e associa uma funcao p cuidar d processamento da info
        AudioObserverManager.OnVolumeChanged += ProcessVolumeChanged;
    }

    private void OnDisable()
    {
        //desinscreve do canal antes de o objeto ser distruido
        //(nesse yt vc n pd excluir a conta sem se desinscrever dos canais)
        AudioObserverManager.OnVolumeChanged -= ProcessVolumeChanged;
    }

    private void ProcessVolumeChanged(float newVolume)
    {
        //decidi q vou colocar o valor que ta chegando na variavel volume, exemplo. decidi q vou assistir o video
        
        volume = newVolume;
        
    }
}
