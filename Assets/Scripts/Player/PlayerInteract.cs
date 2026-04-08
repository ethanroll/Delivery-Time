using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    public static bool interactPressed;
    
    private void OnInteract()
    {
        interactPressed = true;
    }
    
    private void LateUpdate()
    {
        interactPressed = false; // stop from triggering repeatedly
    }
}