using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.SceneManagement; 

public class Start_Game_Script: MonoBehaviour
{
    public InputActionReference next_level;

    private void OnEnable()
    {
        Debug.Log("SCRIPT ENABLED");
        next_level.action.Enable();
        next_level.action.started += Next_Level_Now;
    }

    private void OnDisable()
    {
        next_level.action.started -= Next_Level_Now;
        next_level.action.Disable();
    }

    private void Next_Level_Now(InputAction.CallbackContext obj)
    {
        Debug.Log("SPACE CLICKED");
        SceneManager.LoadScene(2);
    }
}
