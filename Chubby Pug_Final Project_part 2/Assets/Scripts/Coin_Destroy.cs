using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Destroys Coin when player collides with it, coin is not destroyed with a car collides with it.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Coin Collected");
        }

    }
}
