using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class Lab_Controller : MonoBehaviour
{
    public UnityEvent L_Controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                L_Controller.Invoke();
            }
    }

    public void Go_To_RoboticsLab()
    {
        Debug.Log("Entering Robotics Lab");
        SceneManager.LoadScene(10);
    }

}
