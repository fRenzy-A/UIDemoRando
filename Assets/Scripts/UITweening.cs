using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class UITweening : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject title, playButton, mainMenuSettingsButton, exitButton, creditsButton,
    pauseResumeButton, pauseSettingsButton, pauseExitButton,
    settingsText, volumeSlider, SFXSlider, dashSettings, settingsBackButton,settingsPanel;

    public CanvasGroup _pauseResume;

    void Start()
    {
        LeanTween.moveLocal(title, new Vector3(98f, 254f, 0), 1.0f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.rotateZ(title, 0f, 0.7f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.scale(title, new Vector3(2.5f, 2.5f, 2.5f), 0.75f).setDelay(0.5f).setEase(LeanTweenType.easeInExpo);
        LeanTween.moveLocalY(playButton, 130f, 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocalY(mainMenuSettingsButton, -60f, 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocalY(exitButton, -240f, 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);

        LeanTween.scale(playButton, new Vector3(2.8f, 2.8f, 2.8f), 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.scale(mainMenuSettingsButton, new Vector3(1.8f, 1.8f, 1.8f), 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.scale(exitButton, new Vector3(1.8f, 1.8f, 1.8f), 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.scale(creditsButton, new Vector3(1.8f, 1.8f, 1.8f), 0.5f).setDelay(1.3f).setEase(LeanTweenType.easeOutCubic);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnteredSettings()
    {

    }
    public void ExitedSettings()
    {

    }

    public void PausedGame()
    {
        LeanTween.alphaCanvas(pauseResumeButton.GetComponent<CanvasGroup>(), 1f, 0.75f).setIgnoreTimeScale(true);
    }

    public void ResumedGame()
    {

    }

    public void EnteredCredits()
    {

    }
}
