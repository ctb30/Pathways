//Last updated Jan 12th 2026 
//Courtney Boyd 
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class Pathway_Selector : MonoBehaviour
{
    public UnityEvent Pathway_Chosen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                Pathway_Chosen.Invoke();
            }
    }

    public void Sci_Pathway()
    {
        Debug.Log("Science Pathway Selected");
        SceneManager.LoadScene(8);//update
    }

    public void Bus_Pathway()
    {
        Debug.Log("Business Pathway Selected");
        SceneManager.LoadScene(10);
    }

    public void Health_Pathway()
    {
        Debug.Log("Healthcare Pathway Selected");
        SceneManager.LoadScene(6);//update
    }
}
