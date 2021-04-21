using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float hInput;
    public float vInput;
    public float movex = 58;
    public float movey = 2;
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
        vInput = Input.GetAxis("Vertical");

        // Controls player movement foward and backward. Meaning left and right across the screen. 
       transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * hInput);

        //Creates player boundry so that the player can only move to the right.
        if (transform.position.x > movex)
        {
            transform.position = new Vector3(movex, transform.position.y, transform.position.z);
            
        }
        if (transform.position.y > movey)
        {
            //Creates top boundry so player cannot jump for infinity.
            transform.position = new Vector3(transform.position.x, movey, transform.position.z);
        }

    }


}

