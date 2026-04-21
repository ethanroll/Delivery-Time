using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " picked up");
            InventoryManager.Instance.items.Add(gameObject.name);
            Destroy(gameObject);
        }
    }
}
