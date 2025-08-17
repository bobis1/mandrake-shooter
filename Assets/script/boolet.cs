using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolet : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
                rb.AddForce(-transform.forward * 5
                , ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
