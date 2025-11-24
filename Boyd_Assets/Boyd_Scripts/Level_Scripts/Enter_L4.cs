using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.SceneManagement; 

public class Enter_L4 : MonoBehaviour
{
    public InputActionReference L4Now;

    private void OnEnable()
    {
        Debug.Log("Enter_L4_Achieved");
        L4Now.action.Enable();
        L4Now.action.started += InputLvl4Scene;
    }

    private void OnDisable()
    {
        L4Now.action.started -= InputLvl4Scene;
        L4Now.action.Disable();
    }

    private void InputLvl4Scene(InputAction.CallbackContext obj)
    {
        Debug.Log("SPACE CLICKED");
        SceneManager.LoadScene(5);
    }
}
