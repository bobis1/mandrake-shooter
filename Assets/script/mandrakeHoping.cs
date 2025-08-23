using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mandrakeHoping : MonoBehaviour
{
    public float nextTimeToHopTimer;
    public int spawnRate;
    public Rigidbody mandrake;

    public float nextTimeToHopConstant;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        nextTimeToHopTimer += Time.deltaTime;
        if (nextTimeToHopTimer >= spawnRate)
        {
            nextTimeToHopTimer = nextTimeToHopConstant;
            mandrake.AddForce(0,10,0, ForceMode.Impulse);
        }
        
    }
}
