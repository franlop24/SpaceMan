using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inGame,
    gameOver 
}

public class GameManager : MonoBehaviour
{

    public GameState currentGameState = GameState.menu;

    public static GameManager sharedInstance;

    void Awake()
    {
        if (!sharedInstance)
        {
            sharedInstance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            StartGame(); 
        }
    }

    public void StartGame()
    {
        SetGameSate(GameState.inGame);
    }

    public void GameOver()
    {
        SetGameSate(GameState.gameOver);
    }

    public void BackToMenu()
    {
        SetGameSate(GameState.menu);
    }

    void SetGameSate(GameState newGameState)
    {
        if(newGameState == GameState.menu)
        {
            //TODO: Preparar la lógica para el menu
        } else if(newGameState == GameState.inGame)
        {
            //TODO: Preparar la escena para jugar
        } else if(newGameState == GameState.gameOver)
        {
            //TODO: Preparar la lógica para el Game Over
        }

        this.currentGameState = newGameState;
    }
}
