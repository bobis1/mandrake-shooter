using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    public Vector3 startingPosition;
    public Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = -1f;
    public Vector3 currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition = transform.position;
        endingPosition.x += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(startingPosition == currentPosition)
        {
            direction *= -1f;
        }
        if(endingPosition == currentPositon)
        {
            direction = -1f;
        }
        speed *= direction;

        transform.position.x = currentPosition.x-speed;

    }


}