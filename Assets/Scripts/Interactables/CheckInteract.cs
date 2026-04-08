using UnityEngine;

public class CheckInteract : MonoBehaviour
{
    public bool isPlayerNear = false;

    void Update()
    {
        if (isPlayerNear && PlayerInteract.interactPressed)
        {
            GetComponent<IInteractable>().Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("something entered " + other.gameObject.name); // check
            if (other.CompareTag("Player"))
                isPlayerNear = true;
        }

    void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
                isPlayerNear = false;
        }
    }

