using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogBehaviour : MonoBehaviour {

    Rigidbody2D rgb;
    public Animator anim;
	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rgb.MovePosition(rgb.position + Vector2.left);
            soundManager.instance.Jump();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rgb.MovePosition(rgb.position + Vector2.right);
            soundManager.instance.Jump();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            rgb.MovePosition(rgb.position + Vector2.up);
            soundManager.instance.Jump();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            rgb.MovePosition(rgb.position + Vector2.down);
            soundManager.instance.Jump();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rgb.MovePosition(rgb.position + Vector2.zero);
    }

}
