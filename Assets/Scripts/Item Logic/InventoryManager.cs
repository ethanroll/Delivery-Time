using UnityEngine;
using System.Collections.Generic; // to use list

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance; // instance of inventory manager
    public List<string> items = new List<string>(); // new list to store picked up items

  //  public bool hasKey = false;
  //  public bool hasItem = false;
   // public bool hasPickaxe = false;
    public GameObject keyIcon; // drag your UI image here in Inspector

    void Awake() { // before start
        Instance = this; 
    } 

  //  public void PickupKey()
    //{
    //    hasKey = true;
   //     keyIcon.SetActive(true); // show the icon on screen
   // }

    //public void PickupPickaxe()
    //{
     //   hasPickaxe = true;
        // set icon
   // }

   // public void AddItem(string pickedUpItem)
   // {
    //    items.Add(pickedUpItem);
   // }

    public bool CheckItem(string item)
    {
        return items.Contains(item);
    }
}

