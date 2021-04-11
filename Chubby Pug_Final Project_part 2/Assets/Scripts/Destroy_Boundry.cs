using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Boundry : MonoBehaviour
{
    public Vector3 outOfBounds = new Vector3(58f, -10.95f, 0.54f);

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 58f)
        {
            Destroy(gameObject);
        }
    }
}
