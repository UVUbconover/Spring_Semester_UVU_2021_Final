using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset_Button : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        UnityEngine.GameObject[] gameObjects = SceneManager.GetSceneByName("SampleScene").GetRootGameObjects();
        Canvas canvas = (Canvas)gameObjects[7].GetComponent("Canvas");
        canvas.enabled = false;
    }
}
