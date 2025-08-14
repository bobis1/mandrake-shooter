using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pigControl : MonoBehaviour
{
    private Rigidbody rb;
    public float maxSpeed;
    public GameObject explosion;
    public Transform explosionPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (rb.velocity.magnitude >= maxSpeed)
        {
            FindObjectOfType<gameManger>().score++;
            GameObject tempExplo = Instantiate(explosion, explosionPoint.position, explosionPoint.rotation);
            Destroy(tempExplo, 3f);
            Destroy(gameObject);



        }
        else if (collision.collider.gameObject.GetComponent<Rigidbody>() != null)
        {
            if(collision.collider.gameObject.GetComponent<Rigidbody>().velocity.magnitude >= maxSpeed)
            {
                FindObjectOfType<gameManger>().score++;
                GameObject tempExplo = Instantiate(explosion, explosionPoint.position, explosionPoint.rotation);
                Destroy(tempExplo, 10f);
                Destroy(gameObject);

            }
        }
    }
}
