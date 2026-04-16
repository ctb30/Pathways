using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class LibArts_Door : MonoBehaviour
{
    public UnityEvent L_Controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                L_Controller.Invoke();
            }
    }

    public void Go_To_McNeer()
    {
        Debug.Log("Entering McNeer");
        SceneManager.LoadScene(13);
    }

}
