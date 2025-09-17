using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stationaryCollectable : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            score++;
            ScoreText.text = score.ToString();
            this.gameObject.SetActive(false);
            print("collision works");
        }


    }
}
