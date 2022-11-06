using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    [Header ("Set in Inspector")]

   // public string replic1;
    public List<string> replics = new List<string>();
    public Text text;
    public bool first;
    public GameObject pingeon;
    public GameObject cloud;
    public string Scene;
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
       
        cloud.SetActive(false);
        if(first){
         pingeon.SetActive(true);
         Invoke("Cloud", 2f);
         print("end");
        }
           Invoke("LoadScene", 2f);     
        }
        }
        if(count == 0 && !cloud.active ){
          cloud.SetActive(true);
            }
    }
    }

    private void Cloud(){
cloud_parret.SetActive(true);
    }

    public void LoadScene(){
    SceneManager.LoadScene(Scene);
    }

    
}
