using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameSate
{
    menu,
    inGame,
    gameOver 
}

public class GameManager : MonoBehaviour
{

    public GameSate currentGameState = GameSate.menu;

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
        
    }

    public void StartGame()
    {

    }

    public void GameOver()
    {

    }

    public void BackToMenu()
    {

    }

    void SetGameSate(GameSate newGameState)
    {
        if(newGameState == GameSate.menu)
        {
            //TODO: Preparar la lógica para el menu
        } else if(newGameState == GameSate.inGame)
        {
            //TODO: Preparar la escena para jugar
        } else if(newGameState == GameSate.gameOver)
        {
            //TODO: Preparar la lógica para el Game Over
        }

        this.currentGameState = newGameState;
    }
}
