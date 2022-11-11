using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyGameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public TextMeshProUGUI  StarsText;
    
    private Health healthPlayer;

    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates gameState = GameStates.Playing;

    

    // Start is called before the first frame update
    void Start()
    {
        if(player == null){
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPlayer.isAlive)
        {
            StarsText.text = "" + player.GetComponent<starsIncrease>().stars;
        }

        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }

                break;
        }
        
    }
}
