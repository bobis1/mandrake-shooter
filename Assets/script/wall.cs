using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public float speed = 1.0f;
    public int direction = 1;
    [Header("Vector3")]
    private Vector3 startingPosition;
    private Vector3 endingPosition;
    public Vector3 currentPositon;
    private Vector3 endingPosition2;
    public float distance = 9;

    void start()
    {
        endingPosition2 = startingPosition;
        endingPosition2.x = startingPosition.x - 2;
        startingPosition = transform.position;
        endingPosition = transform.position;
        currentPositon = startingPosition;
        endingPosition.x = startingPosition.x + distance;
        Debug.Log(endingPosition);
        Debug.Log(startingPosition);
    }

    void FixedUpdate()
    {
        if (transform.position.x >= -4 || transform.position.x <= -20.445)
        {
           
            direction *= -1;
        }
        currentPositon.x = transform.position.x + speed * direction * Time.fixedDeltaTime;
         currentPositon.y = transform.position.y;
         currentPositon.z = transform.position.z;
      
        
         transform.position = currentPositon;
        currentPositon = transform.position; 
        
    }

}