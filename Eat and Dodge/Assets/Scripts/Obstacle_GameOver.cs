using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Obstacle_GameOver : MonoBehaviour
{
    public GameObject gameOver;

   // Start is called before the first frame update
   void Start()
   {
        GetComponent<GameObject>().CompareTag("GameOver");
   }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Destroy the food the dog(the trigger) collides with.
        Debug.Log("You Died");
        Destroy(gameObject);
        gameOver.SetActive(true); 
    }

}
