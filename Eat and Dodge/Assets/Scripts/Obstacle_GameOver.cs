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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
    }
    
    public void OnTriggerEnter(Collider other)
    {
        //Destroy the food the dog(the trigger) collides with.
        Debug.Log("You Died");

        isGameActive = false;

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
