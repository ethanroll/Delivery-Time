using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && InventoryManager.Instance.hasKey)
        {
            GetComponent<Collider2D>().isTrigger = true;
            InventoryManager.Instance.keyIcon.SetActive(false);
            Debug.Log("You have opened the door!");
        }
    }
}
