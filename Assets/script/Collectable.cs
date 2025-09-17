using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float speed = 1.0f;
    public scoreManager scoreManager;
    public int direction = 1;
    [Header("Vector3")]
    private Vector3 startingPosition;
    private Vector3 endingPosition;
    public Vector3 currentPositon;
    private Vector3 endingPosition2;
    public float distance = 9;

    void Start()
    {
        endingPosition2 = startingPosition;
        endingPosition2.x = startingPosition.x - 2;
        startingPosition = transform.position;
        endingPosition = transform.position;
        currentPositon = startingPosition;
        endingPosition.x = startingPosition.x + distance;
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


        private void OnTriggerEnter(Collider other)
        {
        if (other.tag == "Player")
        {
            scoreManager.score += 2;
            gameObject.SetActive(false);
        }
        }







}