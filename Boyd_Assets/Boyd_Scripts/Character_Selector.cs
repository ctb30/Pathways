using UnityEngine;
using UnityEngine.Events; 

public class Character_Selector : MonoBehaviour
{
    public UnityEvent Character_Selection; 

    public SpriteRenderer ThisPerson_Graphic;

    public SpriteRenderer LastPerson_Graphic;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            {
                Character_Selection.Invoke();
            }
    }

    public void TestMethod()
    {
        Debug.Log("Character Collision detected");
    }

    public void Update_to_ThisPerson_Graphic(){
        LastPerson_Graphic.sprite = ThisPerson_Graphic.sprite; 

    }

}
