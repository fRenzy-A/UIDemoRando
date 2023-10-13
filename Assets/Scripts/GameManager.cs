using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject UIManager;
    public GameObject SceneManager;
    public GameObject Player;

    private UIManager _UIScript;
    private LevelManager _SceneManagerScript;
    private MouseLook _MouseLook;

    public enum GameState { MainMenu,Options, Game, Exit, Win, Lose, PauseMenu, Credits}

    public GameState gameState;
    public GameState previousGameState;
    // Start is called before the first frame update
    void Start()
    {
        _UIScript = UIManager.GetComponent<UIManager>();
        _SceneManagerScript = SceneManager.GetComponent<LevelManager>();
        
        gameState = GameState.MainMenu;
    }

    // Update is called once per frame
    void Update()
    {
        if (_SceneManagerScript.scene != 0)
        {
            gameState = GameState.Game;
        }
        switch (gameState)
        {
            case GameState.MainMenu:
                previousGameState = gameState;
                Time.timeScale = 1f;
                _UIScript.SwitchToMainMenu();
                break;
            case GameState.Options:
                _UIScript.SwitchToOptions();
                break;
            case GameState.Game:
                previousGameState = gameState;
                Time.timeScale = 1f;
                
                _UIScript.SwitchToGameplay();
                Player = GameObject.FindWithTag("Player");
                _MouseLook = Player.GetComponent<MouseLook>();
                _MouseLook.canLook = true;

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    gameState = GameState.PauseMenu;
                }
                if (Input.GetKeyDown(KeyCode.T))
                {
                    gameState = GameState.Win;
                }
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    gameState = GameState.Lose;
                }

                break;

            case GameState.PauseMenu:
                previousGameState = gameState;
                _UIScript.SwitchToPauseScreen();
                Time.timeScale = 0f;           
                _MouseLook.canLook = false;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Time.timeScale = 1f;
                    _UIScript.SwitchToGameplay();
                    gameState = GameState.Game;
                }
                break;
            case GameState.Win:
                Time.timeScale = 0f;
                _UIScript.SwitchToWinScreen();
                _MouseLook.canLook = false;
                break;
            case GameState.Lose:
                Time.timeScale = 0f;
                _UIScript.SwitchToLoseScreen();
                _MouseLook.canLook = false;
                break;
            case GameState.Credits:
                _UIScript.SwitchToCredits();
                _MouseLook.canLook = false;
                break;
        }
    }

    public void LoadThisLevel()
    {
        _SceneManagerScript.LoadLevel(1); 

        _UIScript.SwitchToGameplay();
        gameState = GameState.Game;
    }

    public void ExitToMenu()
    {
        gameState = GameState.MainMenu;
        _SceneManagerScript.LoadLevel(0);
    }

    public void ResumeLevel()
    {
        Time.timeScale = 1f;
        _UIScript.SwitchToGameplay();
        gameState = GameState.Game;
    }

    public void EnterOptions()
    {
        gameState = GameState.Options;
    }

    public void OpenCredits()
    {
        gameState = GameState.Credits;
    }
    public void ExitThisCurrentMenu()
    {
        gameState = previousGameState;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
