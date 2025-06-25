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
        currentPosition = transform.position;
        if(currentPosition.x <= startingPosition.x)
        {
            direction = -direction;
        }
        if (currentPosition.x >= endingPosition.x) 
        { 
            direction = -direction;
        }
        speed *= direction;
        transform.position.x += speed * Time.deltaTime;
    }
}
