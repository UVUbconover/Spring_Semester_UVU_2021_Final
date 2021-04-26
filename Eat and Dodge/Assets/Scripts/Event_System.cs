using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Event_System : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.GameObject[] gameObjects = SceneManager.GetSceneByName("SampleScene").GetRootGameObjects();
        Canvas canvas = (Canvas)gameObjects[7].GetComponent("Canvas");
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
