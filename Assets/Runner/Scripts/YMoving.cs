using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YMoving : MonoBehaviour
{
    public float distance = 5f;
    public float speed = 2f; 

    private Vector3 startPosition;
    private Vector3 endPosition;  
    private bool moveUp = true;  

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + new Vector3(0, distance, 0);
    }

    void Update()
    {
        if (moveUp && transform.position.y >= endPosition.y)
        {
            moveUp = false;
        }
        else if (!moveUp && transform.position.y <= startPosition.y)
        {
            moveUp = true;
        }

        if (moveUp)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
