using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundOnHit : MonoBehaviour
{
    public GameObject Object;
    public GameObject sound;
    public GameObject boolets;
    public GameObject SoundManager;

    // Start is called before the first frame update
    void Start()
    {
        sound.SetActive(false);
        boolets.SetActive(false);
        SoundManager.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SoundManager.SetActive(false);
            sound.SetActive(true);
            boolets.SetActive(true);
        }


    }
    

}
