using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject UIManager;

    public UIManager _UIScript;
    public enum GameState { MainMenu, Options, Credits, Exit, Win, Lose, PauseMenu}

    public GameState UIState;
    public GameState previousUIState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (UIState)
        {
            case GameState.MainMenu:
                _UIScript.SwitchToMainMenu(); break;
            case GameState.Options:
                _UIScript.SwitchToOptions(); break;
            case GameState.Credits:
                _UIScript.SwitchToCredits(); break;
            case GameState.Exit:
                break;
            case GameState.PauseMenu:
                _UIScript.SwitchToPauseScreen(); break;
            case GameState.Win:
                _UIScript.SwitchToWinScreen(); break;
            case GameState.Lose:
                _UIScript.SwitchToLoseScreen(); break;


        }
    }
}
