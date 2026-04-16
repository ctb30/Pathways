
using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; 
using UnityEngine.UI; 
public class McNeer_Libarts_Controller : MonoBehaviour
{
    public InputActionReference Switch_To_Franke, Switch_To_SA_Lib, Return_To_McNeer_Lib;
    public GameObject Meet_Franke, Study_A,McNeer_Background; 

    private void OnEnable()
    {
        Debug.Log("Room Switcher Reached");

        Switch_To_Franke.action.Enable();
        Switch_To_Franke.action.started += Franke_Room_Selector;

        Switch_To_SA_Lib.action.Enable(); 
        Switch_To_SA_Lib.action.started += StudyAbroad_Room_Selector;

        Return_To_McNeer_Lib.action.Enable(); 
        Return_To_McNeer_Lib.action.started += Return_Selector;
    }

    private void OnDisable()
    {
        Switch_To_Franke.action.started -= Franke_Room_Selector;
        Switch_To_Franke.action.Disable();
    }

    private void Franke_Room_Selector(InputAction.CallbackContext obj)
    {
        Debug.Log("Franke_Room_Selector_Reached");
        McNeer_Background.SetActive(false); 
        Meet_Franke.SetActive(true); 
        Study_A.SetActive(false);
    }

    private void Return_Selector(InputAction.CallbackContext obj){
        Debug.Log("Return_Selector_Reached");
        McNeer_Background.SetActive(true);
        Meet_Franke.SetActive(false);
        Study_A.SetActive(false);
    }

    private void StudyAbroad_Room_Selector(InputAction.CallbackContext obj){
        Debug.Log("StudyAbroad_room_Selector_Reached");
        McNeer_Background.SetActive(false);
        Study_A.SetActive(true);
        Meet_Franke.SetActive(false);
    }

}