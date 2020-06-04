using System.Collections;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMAn;
    public string[] dialogueLines;
    public bool trigered;
    
    // Start is called before the first frame update
    void Start()
    {
        dMAn = FindObjectOfType<DialogueManager>();
        dMAn.ShowBox(dialogue);
        trigered = false;
    }

    // Update is called once per frame
    void Update()
    {       
        if (trigered && Input.GetKeyDown(KeyCode.L))
        {
            //dMAn.ShowBox(dialogue);
            if (trigered && !dMAn.dialogActive)
            {
                dMAn.dialogueLines = dialogueLines;
                dMAn.currentLine = 0;
                dMAn.ShowDialogue();
            }

        }       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player") trigered = true;       
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player") trigered = false;
    }
}
