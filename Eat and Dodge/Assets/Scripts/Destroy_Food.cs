using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Food : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Destroy the food the dog(the trigger) collides with.
        Debug.Log("Yum");
        Destroy(gameObject);
    }
}
