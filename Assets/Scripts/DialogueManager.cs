using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogActive;
    public string[] dialogueLines;
    public int currentLine;

    void Start()
    {
        dBox.SetActive(false);
        dialogActive = false;
    }

   
    void Update()
    {
        
        if (dialogActive && Input.GetKeyDown(KeyCode.L)) 
        {
            //Debug.Log("Ta da!");
            dText.text = dialogueLines[currentLine];
            currentLine++;
        }
        if (dialogActive && Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Ta da!");
            dText.text = dialogueLines[currentLine];
            currentLine++;
        }
        if (currentLine >= dialogueLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
        }
        
    }

    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;       
    }

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
    }
}