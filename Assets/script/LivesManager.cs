using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public int lives;
    public GameObject[] hearts;
    public LivesManager livesManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveLife()
    {
        lives -= 1;
        hearts[lives].SetActive(false);
    }
}
