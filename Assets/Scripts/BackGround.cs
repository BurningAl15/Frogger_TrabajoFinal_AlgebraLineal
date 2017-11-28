using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {
    SpriteRenderer render;
    public Color color;
    public float r, g, b;
    // Use this for initialization
    void Start () {
        render = GetComponent<SpriteRenderer>();
        r = Random.RandomRange(0.2f, 0.8f);
        g = Random.RandomRange(0.2f, .8f);
        b = Random.RandomRange(0.2f, .8f);
        color = new Color(r, g, b);
        render.color = color;
    }
	
}
