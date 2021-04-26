using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Move : MonoBehaviour
{
  
    public float foodSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed);
        //destroys object at boudery
        if(transform.position.z > 6f)
        {
            Destroy(gameObject);
        }
    }

}
