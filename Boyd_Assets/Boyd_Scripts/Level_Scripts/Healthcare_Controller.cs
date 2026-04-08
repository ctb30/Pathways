using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class Healthcare_Controller : MonoBehaviour
{
    public UnityEvent H_Controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                H_Controller.Invoke();
            }
    }

    public void Go_To_McNeer()
    {
        Debug.Log("Entering McNeer");
        SceneManager.LoadScene(7);//update
    }
    public void Go_To_Lobby()
    {
        Debug.Log("Entering Lobby");
        SceneManager.LoadScene(6);
    }
    public void Go_To_SleepStudy()
    {
        Debug.Log("Entering SleepLab");
        SceneManager.LoadScene(13);
    }
    public void Go_To_StudyAbroad()
    {
        Debug.Log("Entering Studyabroad");
        SceneManager.LoadScene(14);
    }
    public void Go_To_MiniGame()
    {
        Debug.Log("Entering MiniGame");
        SceneManager.LoadScene(15);
    }
    //public void Collect_Alarm_Clock()
    //{
       // Debug.Log("Collected Alarm Clock");
       // Destroy(gameObject);

    //}

}
