using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour
{
    
    public Toggle tg0;
    public GameObject sprite;

    public void Active(){
if(tg0.isOn){
    sprite.SetActive(true);
}else{
    sprite.SetActive(false);
  }
}
    }

