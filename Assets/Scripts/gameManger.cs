using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManger : MonoBehaviour
{
   public List<GameObject> pigs = new List<GameObject>();
    public GameObject brick;
    public int score;
    public bool endless;

    public Transform vecMin;
    public Transform vecMax;

    private float nextTimeToSpawn;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(endless)
        {
            nextTimeToSpawn += Time.deltaTime;
            if (nextTimeToSpawn >= spawnRate)
            {
                nextTimeToSpawn = 0;
                SpawnPigAtRandomPosition();
            }
        }    
        else if(!endless && score >= GameObject.FindGameObjectsWithTag("pig").Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


       
    }

    void SpawnPigAtRandomPosition()
    {
        Vector3 spawnPos = new Vector3(Random.Range(vecMin.position.x,
            vecMax.position.x), Random.Range(vecMin.position.y, vecMax.position.y),
                Random.Range(vecMin.position.z, vecMax.position.z));

        int pigIndex = Random.Range(0, pigs.Count - 1);

        GameObject tempPig = Instantiate(pigs[pigIndex], spawnPos, Quaternion.identity);


    }
}
