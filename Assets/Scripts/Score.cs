using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int counter;
    public string score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pickup").Length;
    }

    // Update is called once per frame
    void Update()
    {
        counter = GameObject.FindGameObjectsWithTag("Pickup").Length;
        score = "Keys Remaining :" + counter.ToString();
        scoreText.text = score;

    }
}
