//McNeer_Sci_Controller.cs
//Last Updated April 8th 
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

    public GameObject McNeer_Background, Meet_Boyd, Meet_Morgan, Study_A;

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
    }

    private void Boyd_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("Boyd_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Meet_Boyd.SetActive(true);

    }

    private void Morgan_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("Morgan_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Meet_Morgan.SetActive(true);
    }
    private void StudyAbroad_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("StudyAbroad_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Study_A.SetActive(true);
    }

}
