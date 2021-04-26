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
        //Gets the Canvas object from my sample scence and disables it so the game over display and reset button are hidden.
        UnityEngine.GameObject[] gameObjects = SceneManager.GetSceneByName("SampleScene").GetRootGameObjects();
        Canvas canvas = (Canvas)gameObjects[7].GetComponent("Canvas");
        canvas.enabled = false;
    }

    
}
