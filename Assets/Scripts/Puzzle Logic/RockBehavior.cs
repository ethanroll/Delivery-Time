using UnityEngine;

public class RockBehavior : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        if (InventoryManager.Instance.CheckItem("Pickaxe"))
        {
            GetComponent<Collider2D>().isTrigger = true;
        }
    }
}
