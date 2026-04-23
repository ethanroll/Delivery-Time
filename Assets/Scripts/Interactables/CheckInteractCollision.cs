using UnityEngine;

public class CheckInteractCollision : MonoBehaviour
{
    public bool isPlayerNear = false;

    void Update()
    {
        if (isPlayerNear && PlayerInteract.interactPressed)
        {
            if (DialogueManager.Instance.isActive) // keep going if more dialogue
                DialogueManager.Instance.NextLine();
            else
                GetComponent<IInteractable>().Interact(); // start interact
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("something entered " + other.gameObject.name); // check
        if (other.gameObject.CompareTag("Player"))
            isPlayerNear = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            isPlayerNear = false;
    }
}

