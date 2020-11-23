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
        //Move ball
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
