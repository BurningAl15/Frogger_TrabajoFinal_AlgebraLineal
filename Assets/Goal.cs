using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Goal : MonoBehaviour {
    public GameObject points;
    public int counter;
    int currentCounter;
    public int topCounter;
    FrogBehaviour player;
    Vector2 startingPos;
    public bool win;
    script background;
    [Range(0,5)]
    public float duration;
    float startDuration;
    private void Start()
    {
        player = FindObjectOfType<FrogBehaviour>();
        startingPos = player.transform.position;
        background = FindObjectOfType<script>();
        win = false;
        duration = 0.2f;
        startDuration = duration;
        
        counter = 0;
        //topCounter = 200;
    }

    private void Update()
    {
        counter = Score.instance.counter;
        //points.GetComponent<Text>().text = "Points: " + counter;
        points.GetComponent<Text>().text = "Points: " + Score.instance.counter;

        //if (counter>0)
        //{
        //    currentCounter = counter;        
        //}

        //if (currentCounter >= topCounter)
        //{
        //    topCounter = currentCounter;
        //}

        //if(win)
        //{ 
        //    duration -= Time.deltaTime;
        //}
        //if (!win)
        //{
        //    background.panel.SetActive(false);
        //}
        //if (duration<=0)
        //{
        //    background.panel.SetActive(true);
        //    duration = startDuration;
        //}

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            //counter += 50;
            Score.instance.AddScore();
            player.transform.position= startingPos;
           win = true;
        }
    }


    //public IEnumerator FadeOut(float duration)
    //{
    //    for (float time = 0; time < duration; time += Time.smoothDeltaTime)
    //    {
    //        background.panel.SetActive(true);
    //        background.panel.GetComponent<Image>().color = new Color(0,0,0, 1);
    //        yield return duration;
    //    }
    //    //StopCoroutine("FadeOut");
    //}

    //public IEnumerator FadeIn(float duration)
    //{
    //    for (float time = 0; time < duration; time += Time.smoothDeltaTime)
    //    {

    //        background.panel.GetComponent<Image>().color = new Color(1,1,1, 0);
    //        background.panel.SetActive(false);
    //        yield return duration;
    //    }
    //    //StopCoroutine("FadeIn");
    //}


}
