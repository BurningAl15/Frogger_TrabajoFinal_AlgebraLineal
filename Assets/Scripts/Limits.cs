using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
