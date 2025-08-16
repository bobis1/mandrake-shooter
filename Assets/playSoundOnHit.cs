using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundOnHit : MonoBehaviour
{
    public GameObject Object;
    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        sound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sound.SetActive(true);
            StartCoroutine("StopThatNoise");

        }


    }
    
    IEnumerator StopThatNoise()
            {
                
                yield return new WaitForSeconds(9);
                sound.SetActive(false);
            }
}
