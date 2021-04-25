using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Move : MonoBehaviour
{
    public float obstacleSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * obstacleSpeed);
        //Destroys object at boundry
        if (transform.position.x > 12f)
        {
            Destroy(gameObject);
        }
    }
}
