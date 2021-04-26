using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float hInput;
    public float vInput;
    public float playerSpeed = 16f;
    public float xLimit = 10.68f, yLimit = 1f, zLimit = 4f;

    

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //Moves player forward and backward
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * hInput);
        //Moves player left and right.
        transform.Translate(Vector3.back * Time.deltaTime * playerSpeed * vInput);

        //Player constraint on x axis, keeps player from moving off the left/right sides of screen.
        if (transform.position.x < -xLimit)
        {
            transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xLimit)
        {
            transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        }

        //Player constraint on z axis, keeps player from moving off the top/bottom of screen.
        if (transform.position.z < -zLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zLimit);
        }
        else if (transform.position.z > zLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zLimit);
        }
    }

  
}
