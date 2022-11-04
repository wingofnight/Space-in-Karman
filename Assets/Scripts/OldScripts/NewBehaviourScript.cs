using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
       
     [Header ("Set in inspector")]

     public GameObject Planet;
     public GameObject Starts;
     public int size = 20;

     public int speed = 10;

     private bool buttonPush = false;

     float x,y,z;
     

     void Start()
     {
       // Planet.transform.localScale = new Vector3(size, size, size);
     x = 8;
     y = 64;
     z = 602;
        
     }

     void Update()
     {
        /*if(buttonPush){
        for (int i = 0; i < speed; i++)
        {
         size++; 
         Planet.transform.localScale = new Vector3(size, size, size); 
        }
        buttonPush = false;
        }*/
     }
     void FixedUpdate()
     {
        if(buttonPush){
        if(z > size)
        { 
            Planet.transform.position = new Vector3(x,y,z);

         Vector3 starsPos =  Starts.transform.position;  
           

            starsPos.z--;
            starsPos.y -= 0.1f;
             Starts.transform.position = starsPos;
        z--;
        y -= 0.1f;}
       
     }
     } 

     public void GoPlanet(){

        buttonPush = true;
         
     }
    
}
