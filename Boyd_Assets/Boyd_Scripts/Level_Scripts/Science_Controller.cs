using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class Science_Controller : MonoBehaviour
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
        SceneManager.LoadScene(9);//update
    }


    public void Caught_Mech_Pup()
    {
        Debug.Log("Caught_Mech_Pup");
        Destroy(gameObject);

    }

}
