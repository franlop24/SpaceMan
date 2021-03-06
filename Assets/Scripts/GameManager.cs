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

    //Objeto GameManager Compartido (Singleton)
    public static GameManager sharedInstance;

    private void Awake()
    {
        //Solo se crea una unica vez el objeto (Singleton)
        if(sharedInstance == null)
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
        if (Input.GetButtonDown("Submit") && currentGameState != GameState.inGame)
        {
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            BackToMenu();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameOver();
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.inGame);
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu()
    {
        SetGameState(GameState.menu);
    }

    private void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.menu)
        {
            //TODO: colocar la lógica del menú
        } else if(newGameState == GameState.inGame)
        {
            //TODO: hay que preparar la escena para jugar
            PlayerController.sharedPlayer.StartGame();
        } else if(newGameState == GameState.gameOver)
        {
            //TODO: preparar el juego para el Game Over
        }

        this.currentGameState = newGameState;
    }
}
