using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 

public class Next_Level_On_Collision : MonoBehaviour
{
    public UnityEvent Next_LVL;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                Next_LVL.Invoke();
            }
    }
    public void TestMethod()
    {
        Debug.Log("AIC Collision detected");
    }
    public void NextLevelNow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
