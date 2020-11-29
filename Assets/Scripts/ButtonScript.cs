using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    private Button playButton;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
        //playButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void playGame()
    {
        Debug.Log(playButton.gameObject.name + " was clicked");
        gameManager.StartGame();
    }*/


}
