//McNeer_Sci_Controller.cs
//Last Updated April 9th 
//Courtney Boyd 
using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; 
using UnityEngine.UI; 

public class McNeer_Sci_Controller : MonoBehaviour
{
    public InputActionReference Room_Switcher;
    public InputActionReference Switch_To_Boyd;
    public InputActionReference Switch_To_Morgan;
    public InputActionReference Switch_To_StudyAbroad;
    public InputActionReference Return_To_McNeer_Sci;
    public GameObject McNeer_Background, Meet_Boyd, Meet_Morgan, Study_A;
    public GameObject Meet_Stewart; 

    private void OnEnable()
    {
        Debug.Log("Room_Switcher_Reached");

        Room_Switcher.action.Enable();
        Room_Switcher.action.started += Steward_Room_Selector;

        Switch_To_Boyd.action.Enable(); 
        Switch_To_Boyd.action.started += Boyd_Room_Selector; 

        Switch_To_Morgan.action.Enable(); 
        Switch_To_Morgan.action.started += Morgan_Room_Selector; 

        Switch_To_StudyAbroad.action.Enable(); 
        Switch_To_StudyAbroad.action.started += StudyAbroad_Room_Selector;

        Return_To_McNeer_Sci.action.Enable(); 
        Return_To_McNeer_Sci.action.started += Return_Selector;

    }

    private void OnDisable()
    {
        Room_Switcher.action.started -= Steward_Room_Selector;
        Room_Switcher.action.Disable();

        Switch_To_Boyd.action.started -= Boyd_Room_Selector;
        Switch_To_Boyd.action.Disable();

        Switch_To_Morgan.action.started -= Morgan_Room_Selector;
        Switch_To_Morgan.action.Disable();

        Switch_To_StudyAbroad.action.started -= StudyAbroad_Room_Selector;
        Switch_To_StudyAbroad.action.Disable(); 

    }
    private void Steward_Room_Selector(InputAction.CallbackContext obj)
    {
        Debug.Log("Steward_Room_Selector_Reached");
        McNeer_Background.SetActive(false); 
        Meet_Stewart.SetActive(true);

        Study_A.SetActive(false);
        Meet_Morgan.SetActive(false);
        Meet_Boyd.SetActive(false);
    }

    private void Boyd_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("Boyd_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Meet_Boyd.SetActive(true);

        Study_A.SetActive(false);
        Meet_Morgan.SetActive(false);
        Meet_Stewart.SetActive(false);

    }

    private void Morgan_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("Morgan_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Meet_Morgan.SetActive(true);

        Study_A.SetActive(false);
        Meet_Boyd.SetActive(false);
        Meet_Stewart.SetActive(false);
    }
    private void StudyAbroad_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("StudyAbroad_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Study_A.SetActive(true);

        Meet_Morgan.SetActive(false);
        Meet_Boyd.SetActive(false);
        Meet_Stewart.SetActive(false);
    }
    private void Return_Selector(InputAction.CallbackContext obj){
        Debug.Log("Return_Selector_Reached");
        McNeer_Background.SetActive(true);
        Study_A.SetActive(false);
        Meet_Morgan.SetActive(false);
        Meet_Boyd.SetActive(false);
        Meet_Stewart.SetActive(false);
    }


}
