using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicActivator : MonoBehaviour
{
    public GameObject Object;

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonUp(0)){
         
            Object.SetActive(true);
        }
    }
}
