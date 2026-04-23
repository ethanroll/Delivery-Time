using UnityEngine;

public class DoorLogic : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        if (InventoryManager.Instance.CheckItem("Key"))
        {
            GetComponent<Collider2D>().isTrigger = true;
            InventoryManager.Instance.keyIcon.SetActive(false);
            Debug.Log("You have opened the door!");
        }
    }
}
