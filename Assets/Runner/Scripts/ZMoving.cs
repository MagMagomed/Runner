using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMoving : MonoBehaviour
{
    public float distance = 5f;
    public float speed = 2f;

    private Vector3 startPos;
    private Vector3 endPos;
    private bool moveForward = true;

    void Start()
    {
        startPos = transform.position;
        endPos = startPos + new Vector3(0, 0, distance);
    }

    void Update()
    {
        if (moveForward && transform.position.z >= endPos.z)
        {
            moveForward = false;
        }
        else if (!moveForward && transform.position.z <= startPos.z)
        {
            moveForward = true;
        }

        if (moveForward)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        else
        {
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
