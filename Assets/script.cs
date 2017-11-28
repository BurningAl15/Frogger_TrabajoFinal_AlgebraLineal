using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

    SpriteRenderer render;
    public Color color;
    public float r, g, b;
    float rA, gA, bA;
    Goal goal;
    //bool change;
    int level;
    int nextLvl=500;
    public GameObject panel;
    public GameObject texto;
    // Use this for initialization
    void Start() {
        render = GetComponent<SpriteRenderer>();
        goal = FindObjectOfType<Goal>();
        r = Random.RandomRange(0f, 1f);
        g = Random.RandomRange(0f, 1f);
        b = Random.RandomRange(0f, 1f);
        color = new Color(r, g, b);
        render.color = color;
        panel.SetActive(false);
        //change = false;
        //level = 0;
    }

    // Update is called once per frame
    void Update() {
        Epilepsia();
        
        color = new Color(r, g, b);
        
        render.color = color;
      
    }

    void Epilepsia()
    {
        if (goal.counter >= 0 && goal.counter < nextLvl )
        {
            level = 0;
        }
        else if (goal.counter >= nextLvl && goal.counter < nextLvl*2 && goal.win)
        {
            level = 1;
            randValues();
            goal.win = false;
        }
        else if (goal.counter >= nextLvl*2 && goal.counter < nextLvl*3 && goal.win)
        {
            level = 2;
            randValues();
            goal.win = false;
        }
        else if (goal.counter >= nextLvl*3 && goal.counter < nextLvl*4 && goal.win)
        {
            level = 3;
            randValues();
            goal.win = false;
        }
        else if (goal.counter >= nextLvl*4 && goal.counter < nextLvl*5 && goal.win)
        {
            level = 4;
            randValues();
            goal.win = false;
        }
        else if (goal.counter >= nextLvl*5 && goal.counter < nextLvl*6 && goal.win)
        {
            level = 5;
            randValues();
            goal.win = false;
        }
        else if (goal.counter >= nextLvl*6 && goal.counter < nextLvl*7 && goal.win)
        {
            level = 6;
            randValues();
            goal.win = false;
        }

    }
    void randValues()
    {
        if (goal.win)
        {
            rA = Random.RandomRange(0f, 1f);
            gA = Random.RandomRange(0f, 1f);
            bA = Random.RandomRange(0f, 1f);
        }

        r = rA;
        g = gA;
        b = bA;
    }
}
