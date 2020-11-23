using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables 
    private float speed = 10.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float fowardInput;
    //private Animation playerAnim;


    // Start is called before the first frame update
    void Start()
    {
        //playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //Player input   
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        //Move vechicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);

        //Turn vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}