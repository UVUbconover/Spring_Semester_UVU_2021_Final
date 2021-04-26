using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score_System : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;


    private void OnTriggerEnter(Collider other)
    {
        theScore += 10;
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
        Destroy(gameObject);
        Debug.Log("Yum");
    }
}
