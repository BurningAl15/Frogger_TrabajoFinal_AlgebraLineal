using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static Score instance;
    public int counter;

    void Awake()
    {
        counter = 0;
        if (Score.instance == null)
        {
            Score.instance = this;
        }
        else if (Score.instance != this)
        {
            Destroy(gameObject);
        }

    }

    public void AddScore()
    {
        counter += 50;
    }
}
