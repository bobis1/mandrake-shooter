using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victoryScript : MonoBehaviour
{
    public GameObject victoryScreen;
    public int barrelCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "barrel")
        {
            barrelCount--;
        }
        if (barrelCount == 0)
        {
            victoryScreen.SetActive(true);
        }
    }
}
