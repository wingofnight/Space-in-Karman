using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    public Toggle tg0;
   // public AudioClip clicFx;
     public AudioSource myFx;
 
      public void Play(){
        if(!tg0.isOn)
       myFx.Play();
       else
       myFx.Stop();
       }


       //myFx.Stop();

   

    
}
