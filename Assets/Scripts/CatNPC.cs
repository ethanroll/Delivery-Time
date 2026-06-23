using UnityEngine;
using System.Collections.Generic;

public class CatNPC : MonoBehaviour, IInteractable
{
    public List<string> requiredItems = new List<string>(); // NPC list 

    public void Interact()
    {
        bool isMissing = false;
        Debug.Log("Interact called");
        Debug.Log("Required items count: " + requiredItems.Count);

        foreach (string item in requiredItems)
        {
            bool has = InventoryManager.Instance.CheckItem(item);
            Debug.Log($"Checking {item}: {has}");
            if (!has) isMissing = true;
        }

        Debug.Log("isMissing: " + isMissing);

        foreach (string item in requiredItems) 
        {
            if (!InventoryManager.Instance.CheckItem(item)) // check each item
            {
                isMissing = true;
            }
        }

        if (isMissing)
        {
            DialogueManager.Instance.StartDialogue(new string[] {
                    "I'm so hungry...",
                    "Oh, it seems that you are still missing some items.",
                    "Please bring back the necessary items: Apple Pie, Bun Dish, Burger." });
        }
        else
        {
            DialogueManager.Instance.StartDialogue(new string[] {
                    "Thanks for the food, meow!"
                });
        }
    }
}
