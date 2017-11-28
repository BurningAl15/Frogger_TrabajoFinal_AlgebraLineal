using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarBehaviour : MonoBehaviour {
    Rigidbody2D rgb;
    public float speed;
    public int dir;

    float[] positionsY0;
    float[] positionsY1;
    float actualPosY;
    float[] positionsX;
    float actualPosX;
    public int tipo;
    public string name;
    Goal goal;
    FrogBehaviour frog;
    [Range(0,3)]
    public float dur;

    //public GameObject lose;
    // Use this for initialization
    void Start () {
        rgb = GetComponent<Rigidbody2D>();
        goal = FindObjectOfType<Goal>();
        frog = FindObjectOfType<FrogBehaviour>();
        //dir = Random.RandomRange(-1, 1);
        //speed= Random.RandomRange(4, 7);
        speed = 3;
        //lose.SetActive(false);
        PlayerPrefs.GetInt("HigherScore",0);

        positionsY0 = new float[2] { -3.02f, 1.3f };
        positionsY1 = new float[2] {  -0.8f, 3.57f };
        positionsX = new float[2] { -10.82f, 8.91f };
        if (tipo == 0)
        {
            dir = 1;
            actualPosY = positionsY0[Random.Range(0, positionsY0.Length)];
            actualPosX = positionsX[0];
        }
        if (tipo==1)
        {
            dir = -1;
            actualPosY = positionsY1[Random.Range(0, positionsY1.Length)];
            actualPosX = positionsX[1];
        }
        this.transform.position = new Vector2(actualPosX, actualPosY);
    }
	
	// Update is called once per frame
	void Update () {
        
      
        Movement();

        if(goal.counter>=500 && goal.counter<1000)
        {
            speed = 4;
        }
        if (goal.counter >= 1000 && goal.counter < 1500)
        {
            speed = 4.5f;
        }
        if (goal.counter >= 1500 && goal.counter < 2000)
        {
            speed = 5;
        }
        if (goal.counter >= 2000 && goal.counter < 2500)
        {
            speed = 5.5f;
        }
        if (goal.counter >= 2500 && goal.counter < 3000)
        {
            speed = 6f;
        }
        if (goal.counter >= 3000 && goal.counter < 3500)
        {
            speed = 6.5f;
        }
    }

    void Movement()
    {
        Vector2 move = new Vector2(dir * speed, 0f);
        rgb.velocity =move;
        Flip();
    }

    public void Flip()
    {
        if (dir > 0) //rgb.velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (dir < 0) //rgb.velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            //SceneManager.LoadScene(name);
            frog.anim.SetTrigger("Die");
            soundManager.instance.Death();
            StartCoroutine(GameController.FindObjectOfType<GameController>().SceneM(dur));
            goal.counter = 0;
        }
    }


    

}
