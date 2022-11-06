using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue : MonoBehaviour
{
    [Header ("Set in Inspector")]

   // public string replic1;
    public List<string> replics = new List<string>();
    public Text text;

    public GameObject pingeon;
    public GameObject cloud;

    public GameObject cloud_parret;
    public string firstText;
    private int count = 0;

    void Start()
    {
         text.text = firstText;
        
    }
    
    void Update()
    {
         if(Input.GetMouseButtonUp(0)){
            
        if(cloud.active){
        if(count < replics.Count){
        text.text = replics[count];
        count++;
        }else if(count == replics.Count){
        pingeon.SetActive(true);
        cloud.SetActive(false);
        Invoke("Cloud", 2f);
        
        }
        }
        if(count == 0){
          cloud.SetActive(true);
            }
    }
    }

    private void Cloud(){
cloud_parret.SetActive(true);
    }

    
}
