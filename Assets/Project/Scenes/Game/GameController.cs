using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameController : Controller
{
    [SerializeField]GraphicRaycaster raycaster;
    PointerEventData pointerEventData;
    EventSystem eventSystem;
    bool isPopup;
    public const string GAME_SCENE_NAME = "Game";
    private void Awake()
    {
        isPopup = false;
        eventSystem = EventSystem.current;
    }
    public override string SceneName()
    {
        return GAME_SCENE_NAME;
    }
    public void SetIsPopupToFalse()
    {
        isPopup = false;
    }

    private void Update()
    {
        DetectRayCast();
    }

    void DetectRayCast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointerEventData = new PointerEventData(eventSystem);

            pointerEventData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();

            raycaster.Raycast(pointerEventData, results);

            if (isPopup == false)
            {
                if (results.Count > 0)
                {
                    if (results[0].gameObject.CompareTag("PausedButton"))
                    {
                        Manager.Add(PauseController.PAUSE_SCENE_NAME);
                    }
                    else
                    {
                        Manager.Add(ResultController.RESULT_SCENE_NAME);
                    }
                    isPopup = true;
                }
            }

        }
    }
}