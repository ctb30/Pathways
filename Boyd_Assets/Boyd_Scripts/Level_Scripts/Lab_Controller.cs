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
        SceneManager.LoadScene(9);//update
    }

    public void Go_To_StudyAbroad()
    {
        Debug.Log("Entering StudyAbroad");
        SceneManager.LoadScene(11);
    }
    public void Go_To_Lobby()
    {
        Debug.Log("Entering Lobby");
        SceneManager.LoadScene(8);
    }
        public void Go_To_MiniGame()
    {
        Debug.Log("Entering MiniGame");
        SceneManager.LoadScene(12);
    }

    public void Caught_Mech_Pup()
    {
        Debug.Log("Caught_Mech_Pup");
        Destroy(gameObject);

    }

}
