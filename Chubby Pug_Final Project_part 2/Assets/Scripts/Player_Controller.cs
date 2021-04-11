using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float hInput;
    public float movex = 58;

    public float movey = 1;
    private Rigidbody rigidB;

   


    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");

        // Controls player movement foward and backward. Meaning left and right across the screen.
       transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * hInput);

        

        //Jump command
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y <= 1f)
            {
                rigidB.AddForce(Vector3.up * 400);
            }
        }

        //Creates player boundry so that the player can only move to the right.
        if (transform.position.x > movex)
        {
            transform.position = new Vector3(movex, transform.position.y, transform.position.z);
        }

        //Creates top boundry so player cannot jump for infinity.
        if (transform.position.y > movey)
        {
            transform.position = new Vector3(transform.position.x, movey, transform.position.z);
        }



    }

  
}

