using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogBehaviour : MonoBehaviour {

    Rigidbody2D rgb;
    public Animator anim;
    public bool alive;
	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        alive = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(alive)
        { 
            Movement();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 izquierda = new Vector2(-1, 0);
            rgb.MovePosition(rgb.position + izquierda);
            soundManager.instance.Jump();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2 derecha = new Vector2(1, 0);
            rgb.MovePosition(rgb.position + derecha);
            soundManager.instance.Jump();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2 arriba = new Vector2(0, 1);
            rgb.MovePosition(rgb.position + arriba);
            soundManager.instance.Jump();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 abajo = new Vector2(0, -1);
            rgb.MovePosition(rgb.position + abajo);
            soundManager.instance.Jump();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 cero = new Vector2(0, 0);
        rgb.MovePosition(rgb.position + cero);
    }

}
