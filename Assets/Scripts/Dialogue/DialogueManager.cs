using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    private bool hasNextLine = false;
    private int currentIndex = 0;
    public bool isActive = false;
    private string[] lines;

    public GameObject dialoguePanel;
    public TMPro.TextMeshProUGUI dialogueText;

    void Awake()
    { // before start
        Instance = this;
    }

    public void StartDialogue(string[] lines)
    {
        isActive = true;
        currentIndex = 0;
        hasNextLine = true;
        this.lines = lines;
    }

    public void NextLine() // check if lines are left
    {
        currentIndex++;
        if(currentIndex == lines.Length)
        {
            hasNextLine = false;
            isActive = false;
        }
        //else(currentIndex < lines.Length){

        //}
    }
}
