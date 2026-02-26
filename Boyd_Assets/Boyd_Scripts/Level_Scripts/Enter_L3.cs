using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.SceneManagement; 

public class Enter_L3 : MonoBehaviour
{
    public InputActionReference L3Now;

    private void OnEnable()
    {
        Debug.Log("Enter_L3_Achieved");
        L3Now.action.Enable();
        L3Now.action.started += InputLvl3Scene;
    }

    private void OnDisable()
    {
        L3Now.action.started -= InputLvl3Scene;
        L3Now.action.Disable();
    }

    private void InputLvl3Scene(InputAction.CallbackContext obj)
    {
        Debug.Log("SPACE CLICKED");
        SceneManager.LoadScene(3);//update
    }
}
