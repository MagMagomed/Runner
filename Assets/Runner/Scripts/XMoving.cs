using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMoving : MonoBehaviour
{
    public float distance = 5f;
    public float speed = 2f;

    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool moveRight = true;

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + new Vector3(distance, 0, 0);
    }

    void Update()
    {
        if (moveRight && transform.position.x >= endPosition.x)
        {
            moveRight = false;
        }
        else if (!moveRight && transform.position.x <= startPosition.x)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
