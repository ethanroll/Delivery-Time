using UnityEngine;

public class RockBehavior : MonoBehaviour, IInteractable
{
    private bool isOpened = false;

    public void Interact()
    {
        if (isOpened)
            return; // stop checking for interaction after already opened

        if (InventoryManager.Instance.CheckItem("Pickaxe"))
        {
            GetComponent<Collider2D>().isTrigger = true;
            DialogueManager.Instance.StartDialogue(new string[]{
                "You destroyed the rocks!"
            } );
            isOpened = true;
        }
        else
        {
            DialogueManager.Instance.StartDialogue(new string[]{
                "Hmm... I think I might need something to break these rocks.",
                "I should keep looking." } );
        }
    }
}
