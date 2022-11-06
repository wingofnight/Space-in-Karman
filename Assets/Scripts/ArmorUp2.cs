using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorUp2: MonoBehaviour
{
   public Toggle tg;
   
   public GameObject armor;
   public float startPosition,endPosition;
   
   private Vector3 pos = new Vector3();
    
   
     //  startPosition += 653;
      // endPosition += 653;

    private void FixedUpdate() {
       if(!tg.isOn && armor.transform.position.y > endPosition)
       armor.transform.Translate(Vector3.down * Time.deltaTime*50,Space.World); 
       else if(armor.transform.position.y < startPosition){
       armor.transform.Translate(Vector3.up * Time.deltaTime*50,Space.World); 
       }
        print(armor.transform.position.y + "   !    ");
    }
     
}
