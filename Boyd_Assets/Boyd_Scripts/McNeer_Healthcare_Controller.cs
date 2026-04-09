//McNeer_Sci_Controller.cs
//Last Updated April 9th 
//Courtney Boyd 
using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; 
using UnityEngine.UI; 

public class McNeer_Healthcare_Controller : MonoBehaviour
{
    public InputActionReference Switch_To_DrV;
    public InputActionReference Switch_To_BonSecour;
    public InputActionReference Switch_To_StudyAbroad1; 
    public InputActionReference Return_To_McNeer_Healthcare; 
    public GameObject Meet_DrV, Meet_BonSecour;
    public GameObject Visit_StudyAbroad, McNeer_Background; 

    private void OnEnable()
    {
        Switch_To_DrV.action.Enable();
        Switch_To_DrV.action.started += DrV_Selector;
        Switch_To_BonSecour.action.Enable();
        Switch_To_BonSecour.action.started += BonSecour_Selector; 
        Switch_To_StudyAbroad1.action.Enable();
        Switch_To_StudyAbroad1.action.started += StudyAbroad_Selector; 

        Return_To_McNeer_Healthcare.action.Enable();
        Return_To_McNeer_Healthcare.action.started += McNeer_Selector; 
    }
    private void OnDisable()
    { 
        Switch_To_DrV.action.started -= DrV_Selector;
        Switch_To_DrV.action.Disable();
        Switch_To_BonSecour.action.started -= BonSecour_Selector;
        Switch_To_BonSecour.action.Disable();
        Switch_To_StudyAbroad1.action.started -= StudyAbroad_Selector; 
        Switch_To_StudyAbroad1.action.Disable();   

        Return_To_McNeer_Healthcare.action.started -= McNeer_Selector;  
        Return_To_McNeer_Healthcare.action.Disable();    
    }
    private void DrV_Selector(InputAction.CallbackContext obj)
    {
        Debug.Log("Dr.V Selector Reached");
        Meet_DrV.SetActive(true); 
        Meet_BonSecour.SetActive(false); 
        Visit_StudyAbroad.SetActive(false);
        McNeer_Background.SetActive(false);
    }
    private void BonSecour_Selector(InputAction.CallbackContext obj)
    {
        Debug.Log("Bon Secour Selector Reached");
        Meet_DrV.SetActive(false); 
        Meet_BonSecour.SetActive(true); 
        Visit_StudyAbroad.SetActive(false); 
        McNeer_Background.SetActive(false);
    }
    private void StudyAbroad_Selector(InputAction.CallbackContext obj)
    {
        Debug.Log("Study Abroad Selector Reached");
        Meet_DrV.SetActive(false); 
        Meet_BonSecour.SetActive(false); 
        Visit_StudyAbroad.SetActive(true); 
        McNeer_Background.SetActive(false);
    }

    private void McNeer_Selector(InputAction.CallbackContext obj)
    {
        Debug.Log("Return Selected");
        Meet_DrV.SetActive(false); 
        Meet_BonSecour.SetActive(false); 
        Visit_StudyAbroad.SetActive(false); 
        McNeer_Background.SetActive(true);
    }







}
