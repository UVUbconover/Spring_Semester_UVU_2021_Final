using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public float speed = 10f;
    public GameObject followPlayer;
    public Vector3 followPlayerOffset;
    private Vector3 threshhold;
    private Rigidbody rB;

    // Start is called before the first frame update
    void Start()
    {
        threshhold = calculateThreshold();
        rB = followPlayer.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 follow = followPlayer.transform.position;
        float xDifference = Vector3.Distance(Vector3.forward * transform.position.x, Vector3.right * follow.x);
        float yDifference = Vector3.Distance(Vector3.up * transform.position.y, Vector3.up * follow.y);

        Vector3 newPosition = transform.position;

        if (Mathf.Abs(xDifference) >= threshhold.x)
        {
            newPosition.x = follow.x;
        }

        if (Mathf.Abs(yDifference) >= threshhold.y)
        {
            newPosition.y = follow.y;
        }

        float moveSpeed = rB.velocity.magnitude > speed ? rB.velocity.magnitude : speed;

        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);

    }

    private Vector3 calculateThreshold()
    {
        Rect aspect = Camera.main.pixelRect;
        Vector3 t = new Vector3(Camera.main.orthographicSize * aspect.width / aspect.height, Camera.main.orthographicSize);
        t.x -= followPlayerOffset.x;
        t.x -= followPlayerOffset.y;
        return t;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Vector3 border = calculateThreshold();
        Gizmos.DrawWireCube(transform.position, new Vector3(border.x * 2, border.y * 2, 1));
    }
}