using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float vInput;
    public float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical"); 

        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * hInput);

        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * vInput);
    }
}
