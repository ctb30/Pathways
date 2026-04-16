// Boyd last update 15 Dec 2025 
using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; 
using UnityEngine.UI; 

public class Omni_Controller : MonoBehaviour
{
    public int myCounter; 
    
    public InputActionReference Omni_Talk;

    public TMP_Text Omni_textbox, Selection_textbox; 

    public SpriteRenderer AIC_Lib_Background; 

    public GameObject Omni_Photo, Omni_Body, Omni_Paper, Selection_Paper; 

    public GameObject BusinessPhoto, HealthcarePhoto, STEMPhoto;

    public GameObject Sci_trigger, Bus_trigger, Heal_trigger; 

  



    private void OnEnable()
    {
        Debug.Log("Omni_Talk_Achieved");
        myCounter = 0; 

        Omni_Talk.action.Enable();
        Omni_Talk.action.started += Next_Phrase;
    }

    private void OnDisable()
    {
        Omni_Talk.action.started -= Next_Phrase;
        Omni_Talk.action.Disable();
    }

    private void Next_Phrase(InputAction.CallbackContext obj)
    {

        Debug.Log("OmniNextPhrase");
        myCounter++; 
        Debug.Log("MyCounter:"+ myCounter);
        if(myCounter == 1)
        {
            Omni_textbox.text=" By attending Richard Bland College and earning an associate degree you will have completed the first two years towards the baccalureate degree. SpaceBar to continue...";
        }
        else if(myCounter == 2)
        {
            Omni_textbox.text=" Let's explore the degrees offered at RBC.  SpaceBar to continue...";
            
        }
        else if(myCounter == 3)
        {
            Omni_textbox.text=" Let's explore the degrees offered at RBC.  SpaceBar to continue...";
        }
        else if(myCounter == 4)
        {
            Omni_textbox.text="We offer an Associates of Science (A.S) Degree with a physical science concentration, life science concentration or math/computer science concentration SpaceBar to continue...";
            Omni_Photo.SetActive(false); 
            Omni_Body.SetActive(false);
            STEMPhoto.SetActive(true);
        }
        else if(myCounter ==5)
        {
            Omni_textbox.text="We offer an Associates of Arts (A.S) Degree with a business concentration. We also offer certificates in Fine Arts, Logistics and Communications SpaceBar to continue...";
            BusinessPhoto.SetActive(true);
        }

        else if(myCounter ==6)
        {
            Omni_textbox.text="We offer an Associates of Science (A.S) Degree with a clinical lab concentration, or behavioral science concentration SpaceBar to continue...";
            HealthcarePhoto.SetActive(true);
        }

        else if(myCounter ==7)
        {
            Omni_textbox.text="";
            Selection_textbox.text = "Jump to select a career pathway!";
            Omni_Paper.SetActive(false);
            Selection_Paper.SetActive(true);
            Sci_trigger.SetActive(true); 
            Bus_trigger.SetActive(true); 
            Heal_trigger.SetActive(true); 


        }

        
    }
}
