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
    }

    public void Bus_Pathway()
    {
        Debug.Log("Business Pathway Selected");
    }

    public void Health_Pathway()
    {
        Debug.Log("Healthcare Pathway Selected");
    }
}
