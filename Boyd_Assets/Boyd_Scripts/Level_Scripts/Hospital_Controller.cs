using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class Hospital_Controller : MonoBehaviour
{
    public UnityEvent H_Controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                H_Controller.Invoke();
            }
    }

    public void Go_To_Nursery()
    {
        Debug.Log("Entering Nursery");
        SceneManager.LoadScene(8);
    }

}
