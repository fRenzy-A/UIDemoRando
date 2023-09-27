using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum State { MainMenu, Options, Credits, Exit, Win, Lose, PauseMenu}

    public State UIState;
    public State previousUIState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (UIState)
        {

        }
    }
}
