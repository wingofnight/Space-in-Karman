using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test : MonoBehaviour
{
    [Header ("Set in inspector")]

    public GameObject buttonStart;
    public Toggle tg0;
    public Toggle tg1;
    public Toggle tg2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!tg0.isOn && !tg1.isOn && tg2.isOn ){
            buttonStart.SetActive(true);
        }else{
            buttonStart.SetActive(false);
        }
    }
}
