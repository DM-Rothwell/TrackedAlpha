using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    //Declare Variables
    public float speed = 35.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Generate ball at spawn pos
        Vector3 spawnPos = new Vector3(Random.Range(0, 0), 1, 0);

        //Move ball
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
