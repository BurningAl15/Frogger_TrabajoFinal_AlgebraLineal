using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {

    public GameObject car;
    [Range(1,5)]
    public float time;
    float startingTime;

    // Use this for initialization
    void Start () {
        
        startingTime = time;
        car.GetComponent<CarBehaviour>().tipo = Random.RandomRange(0, 2);
        //car.GetComponent<CarBehaviour>().speed = 4;
    }
	
	// Update is called once per frame
	void Update () {

        time -= Time.deltaTime;
        if(time<=0)
        {
            Instantiate(car, car.transform.position, Quaternion.identity);
            car.GetComponent<CarBehaviour>().tipo = Random.RandomRange(0, 2);
            time = startingTime;
        }

	}
}
