using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    //Declare the maxiumum and minimum points for the boundary
    float xMin = -5f;
    float xMax = 5f;
    float yMin = -7f;
    float yMax = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Prevent player from leaving the boundary off the map
    void ConstrainPlayerPosition()
    {
        Vector3 playerPosition = transform.position;

        //Create if statement
        if(playerPosition.x > xMax){
            playerPosition.x = xMax;
        } 

        else if (playerPosition.y > yMax){
            playerPosition.y = yMax;
        } 
        
        else if (playerPosition.x < xMin){
            playerPosition.x = xMin;
        }
        
        else if (playerPosition.y < yMin){
            playerPosition.y = yMin;
        }//End of if statements


    }
}
