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

    // starts dialogue
    public void StartDialogue(string[] lines)
    {
        isActive = true; // dialogue now active
        currentIndex = 0;
        hasNextLine = true;
        this.lines = lines; // take array in parameter, store in field for access later

        // activate text box UI
        dialoguePanel.SetActive(true);
        dialogueText.text = lines[0];
    }

    // checks if lines are left
    public void NextLine()
    {
        currentIndex++;
        if(currentIndex < lines.Length) // continue if lines are still found
        {
            dialogueText.text = lines[currentIndex];
        }
        else {
            // end dialogue if there are no more lines left
            dialoguePanel.SetActive(false);
            hasNextLine = false;
            isActive = false;
        }
    }
}
