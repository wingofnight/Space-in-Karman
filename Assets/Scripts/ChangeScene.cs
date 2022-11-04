using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [Header ("Set in Inspector")]
    public string Scene;

    public void LoadScene(){
    SceneManager.LoadScene(Scene);
    }
}
