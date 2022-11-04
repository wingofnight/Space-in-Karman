using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class txtping : MonoBehaviour
{
    [Header ("Set in inspector")]
public GameObject txt_pingeon;
public GameObject promo;


//public GameObject button;
    int set = 1;
public List <string> Texts = new List<string>{"Привет, грязный Гарри!", "Готов к приключениям?", "Дави гашетку!!!"};
  
  void Start()
  {
    Texts.Add("aaaaa");
  //  button.SetActive(false);
    PrintText(0);
  }

  void Update()
  {
    TextPingeon();
  }
   void TextPingeon(){

    if(Input.GetMouseButtonUp(0) && set < 4 ){
         
        PrintText(set);
        set++;
       
    }
    
    if(set == 4){
        promo.SetActive(false);
       // button.SetActive(true);
    }
    
    
   }

   void PrintText(int set){
   txt_pingeon.GetComponent<TMP_Text>().text = Texts[set];
   }
}
