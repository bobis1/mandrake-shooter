using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoryScript2 : MonoBehaviour
{
    public int barrelCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "barrel")
        {
            barrelCount--;
        }
        if (barrelCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
