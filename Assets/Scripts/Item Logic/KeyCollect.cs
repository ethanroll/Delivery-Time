using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Key picked up");
            //DialogueManager.Instance.StartDialogue(new string[] {
            //    "Key picked up."
           // } );

           // InventoryManager.Instance.AddItem("Key");
            Destroy(gameObject); // remove key from scene
        }
    }
}