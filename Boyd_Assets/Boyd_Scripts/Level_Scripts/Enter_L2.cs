using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.SceneManagement; 

public class Enter_L2 : MonoBehaviour
{
    public InputActionReference L2Now;

    private void OnEnable()
    {
        Debug.Log("Enter_L2_Achieved");
        L2Now.action.Enable();
        L2Now.action.started += InputLvl2Scene;
    }

    private void OnDisable()
    {
        L2Now.action.started -= InputLvl2Scene;
        L2Now.action.Disable();
    }

    private void InputLvl2Scene(InputAction.CallbackContext obj)
    {
        Debug.Log("SPACE CLICKED");
        SceneManager.LoadScene(2);//update
    }
}
