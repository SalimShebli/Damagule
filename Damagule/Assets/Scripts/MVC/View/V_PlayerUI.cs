using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class V_PlayerUI : MonoBehaviour {

    public C_MainPlayer mainPlayer;
    public Slider BootSlider;
    enum Action { Rightbutton, Leftbutton, Slider, None };
    Action currentAction = Action.None;
	// Use this for initialization
    void Start()
    {

    }
    void Update()
    {
      
        if(currentAction==Action.Rightbutton)
        {
            mainPlayer.MoveRight();
        }
        else if(currentAction==Action.Leftbutton)
        {
            mainPlayer.MoveLeft();
        }
    }
    public void OnRightButtonPressed()
    {
        currentAction = Action.Rightbutton;
    }
    public void OnRightButtonUp()
    {
        currentAction = Action.None;
    }
    public void OnLeftButtonPressed()
    {
        currentAction = Action.Leftbutton;
    }
    public void OnLeftButtonUp()
    {
        currentAction = Action.None;
    }
    public void OnSliderShangeValue()
    {
        currentAction = Action.Slider;
    }
    public void OnSliderUp()
    {
        mainPlayer.UpdateBootsNumber((int)BootSlider.value);
        print((int)BootSlider.value);
        currentAction = Action.None;
    }
    public void OnExitPressed()
    {
        Application.Quit();
    }
}
