using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class PauseController : Controller
{
    public const string PAUSE_SCENE_NAME = "Pause";
    GameController gameController;
    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }
    public override string SceneName()
    {
        return PAUSE_SCENE_NAME;
    }
    public void OnResumeButtonClick()
    {
        gameController.SetIsPopupToFalse();
    }
    public void OnQuitButtonClick()
    {
        Manager.Load(HomeController.HOME_SCENE_NAME);
    }
}