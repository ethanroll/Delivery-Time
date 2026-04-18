using UnityEngine;
using System.Collections.Generic;

public class CatNPC : MonoBehaviour, IInteractable
{
    public List<string> requiredItems = new List<string>(); // NPC list

    public void Interact()
    {
        bool isMissing = false;

        foreach (string item in requiredItems) 
        {
            if (!InventoryManager.Instance.CheckItem(item)) // check each item
            {
                DialogueManager.Instance.StartDialogue(new string[] {
                    "I'm so hungry...", 
                    "Oh, it seems that you are still missing some items.", 
                    "Please bring back the necessary items: Apple Pie, Bun Dish, Burger." } );

                //Debug.Log("You are still missing some items. Please bring back the necessary items: Apple Pie, Bun Dish, Burger.");
                isMissing = true;
            }
        }

        if (isMissing != true)
        {
            DialogueManager.Instance.StartDialogue(new string[] { 
                "Thanks for the food, meow!" 
            });
            //Debug.Log("Thank you for your service!~");
        }
    }
}
