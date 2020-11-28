using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //Declare Variables
    private int score;
    public TextMeshProUGUI scoreText;
    public bool gameActive;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateScore(0);

        /*IEnumerator SpawnManager()
        {
            while (true)
            {
                UpdateScore(1);
            }//End of while
        }//end of IEnumerator*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "Score: " + score;
    }

    //Method to start game when "Play Game" is clicked
    public void StartGame()
    {
        gameActive = true;
        score = 0;

        //StartCoroutine(SpawnManager());
        UpdateScore(0);
    }
}

