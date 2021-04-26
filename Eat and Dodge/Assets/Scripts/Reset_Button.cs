using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset_Button : MonoBehaviour
{


    public void OnMouseDown()
    {
        //Gets my cavas object from the sample scene and deactivates it when the mouse clicks the button allowing the player to continue playing.
        UnityEngine.GameObject[] gameObjects = SceneManager.GetSceneByName("SampleScene").GetRootGameObjects();
        Canvas canvas = (Canvas)gameObjects[7].GetComponent("Canvas");
        canvas.enabled = false;
    }
}
