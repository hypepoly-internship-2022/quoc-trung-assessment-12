using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class ResultController : Controller
{
    public const string RESULT_SCENE_NAME = "Result";

    public override string SceneName()
    {
        return RESULT_SCENE_NAME;
    }
    public void OnHomeButtonClick()
    {
        Manager.Load(HomeController.HOME_SCENE_NAME);
    }
    public void OnVoteButtonClick()
    {
        Manager.Add(VotePopupController.VOTEPOPUP_SCENE_NAME);
    }
}