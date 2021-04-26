using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Obstacle_GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button resetButton;
    public bool isGameActive = true;

   
    
    public void OnTriggerEnter(Collider other)
    {
        //Destroy the food the dog(the trigger) collides with.
        Debug.Log("You Died");

        isGameActive = false;

        //Gets my Canvas object from the sample scene and activates it when the game is over.
        UnityEngine.GameObject[] gameObjects = SceneManager.GetSceneByName("SampleScene").GetRootGameObjects();
        Canvas canvas = (Canvas) gameObjects[7].GetComponent("Canvas");
        canvas.enabled = true;

        Destroy(gameObject);
    }

    public void GameOver()
    {
        //gameOverText.gameObject.SetActive(false);
        //resetButton.gameObject.SetActive(false);
    }

    public void RestGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
