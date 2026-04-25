using UnityEngine;

public class DoorLogic : MonoBehaviour, IInteractable
{
    private bool isOpened = false;

    public void Interact()
    {
        if (isOpened)
            return; // stop checking for interaction after already opened

        if (InventoryManager.Instance.CheckItem("Key"))
        {
            GetComponent<Collider2D>().isTrigger = true;
            InventoryManager.Instance.keyIcon.SetActive(false);
            DialogueManager.Instance.StartDialogue(new string[] {
                "You opened the door!"
                });
            isOpened = true;
        }
        else
        {
            DialogueManager.Instance.StartDialogue(new string[] {
                "Hmm... I think I might need a key to open this door.",
                "There should be a key somewhere close." });
        }
    }
}
