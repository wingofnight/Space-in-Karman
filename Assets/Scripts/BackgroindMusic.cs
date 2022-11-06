using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackgroindMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
 
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        /*if (scene.name == "3")
            audio.mute = true;
        else
            audio.mute = false;*/
    }
 
    void Destroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
