using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thumblers_fx : MonoBehaviour

{
    public AudioSource myFx;
    public AudioClip clicFx;
   

  public void SFX(){
    myFx.PlayOneShot(clicFx);
   }
}
   

