using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    void Awake()
    { // before start
        Instance = this;
    }

    public void StartDialogue(string[] lines)
    {

    }

    public void NextLine() // check if lines are left
    {
        if()
    }
}
