using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Key picked up");
            InventoryManager.Instance.PickupKey();
            Destroy(gameObject); // remove key from scene
        }
    }
}