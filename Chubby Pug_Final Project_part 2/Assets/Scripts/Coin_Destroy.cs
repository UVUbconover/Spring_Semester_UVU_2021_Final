using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Destroy : MonoBehaviour
{
    public AudioClip coinCollected;
    private AudioSource playerSounds;

    // Start is called before the first frame update
    void Start()
    {
        playerSounds = GetComponent<AudioSource>();
    }

    //Destroys Coin when player collides with it, coin is not destroyed with a car collides with it.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            playerSounds.PlayOneShot(coinCollected);
            Debug.Log("Coin Collected");
        }

    }
}
