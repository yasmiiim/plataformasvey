using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//nosso youtube de coisas de audio
public static class AudioObserverManager
{
  //criar o ponto que permite aos interessados se inscreverem no canal

  public static event Action<float> OnVolumeChanged;
  
  //permite que o criador do valor do slider mande os dados para o canal

  public static void ChangeVolumeSliderValue(float sliderValue)
  {
    //tem algm escrito se tiver manda notifi
    
    OnVolumeChanged?.Invoke(sliderValue);
  }

}
