using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

using JetBrains.Annotations;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public Canvas MenuUI;
    public Canvas GameUI;
    public Canvas WinUI;
    public Canvas LoseUI;
    public Canvas PauseUI;
    public Canvas OptionsUI;
    public Canvas CreditsUI;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToMainMenu()
    {
        MenuUI.enabled = true;
        GameUI.enabled = false;
        WinUI.enabled = false;
        LoseUI.enabled = false;
        PauseUI.enabled = false;
        OptionsUI.enabled = false;
        CreditsUI.enabled = false;
    }
    public void SwitchToOptions()
    {
        MenuUI.enabled = false;
        GameUI.enabled = false;
        WinUI.enabled = false;
        LoseUI.enabled = false;
        PauseUI.enabled = false;
        OptionsUI.enabled = true;
        CreditsUI.enabled = false;
    }
    public void SwitchToCredits()
    {
        MenuUI.enabled = false;
        GameUI.enabled = false;
        WinUI.enabled = false;
        LoseUI.enabled = false;
        PauseUI.enabled = false;
        OptionsUI.enabled = false;
        CreditsUI.enabled = true;
    }
    public void SwitchToGameplay()
    {
        MenuUI.enabled = false;
        GameUI.enabled = true;
        WinUI.enabled = false;
        LoseUI.enabled = false;
        PauseUI.enabled = false;
        OptionsUI.enabled = false;
        CreditsUI.enabled = false;
    }
    public void SwitchToWinScreen()
    {
        MenuUI.enabled = false;
        GameUI.enabled = false;
        WinUI.enabled = true;
        LoseUI.enabled = false;
        PauseUI.enabled = false;
        OptionsUI.enabled = false;
        CreditsUI.enabled = false;
    }
    public void SwitchToLoseScreen()
    {
        MenuUI.enabled = false;
        GameUI.enabled = false;
        WinUI.enabled = false;
        LoseUI.enabled = true;
        PauseUI.enabled = false;
        OptionsUI.enabled = false;
        CreditsUI.enabled = false;
    }

    public void SwitchToPauseScreen()
    {
        MenuUI.enabled = false;
        GameUI.enabled = false;
        WinUI.enabled = false;
        LoseUI.enabled = false;
        PauseUI.enabled = true;
        OptionsUI.enabled = false;
        CreditsUI.enabled = false;
    }

    
}
