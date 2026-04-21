using UnityEngine;

public class PickaxeCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Pickaxe picked up.");
       // InventoryManager.Instance.AddItem("Pickaxe");
        Destroy(gameObject);
    }
}
