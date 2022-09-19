using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public Text nameText;
    public GameObject dialogBox;
    public GameObject nameBox;

    public GameObject AR;

    public string[] dialogLines;

    public int currentLine;
    public bool justStarted;

    public static DialogManager instance;


    // Start is called before the first frame update    
    void Start()
    {
        instance = this;

        //dialogText.text = dialogLines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogBox.activeInHierarchy)
        {
            if(Input.GetButtonUp("Fire1"))
            {
                if(!justStarted)
                {
                    AlienGuy();
                    currentLine++;
                    

                    if(currentLine >= dialogLines.Length)
                    {
                        dialogBox.SetActive(false);

                        PlayerController.instance.canMove = true;
                    } 
                    else
                    {
                        CheckIfName();
                        dialogText.text = dialogLines[currentLine];
                    }
                }
                else
                {
                    justStarted = false;
                }
            }
        }
    }

    public void ShowDialog(string[] newLines)
    {
        dialogLines = newLines;

        currentLine = 0;

        CheckIfName();

        dialogText.text = dialogLines[currentLine];

        dialogBox.SetActive(true);

        justStarted = true;

        PlayerController.instance.canMove = false;
    }

    public void CheckIfName()
    {
        if(dialogLines[currentLine].StartsWith("n-"))
        {
            nameText.text = dialogLines[currentLine].Replace("n-", " ");
            
            currentLine++;
    
        }

    }

    public void AlienGuy()
    {
        if(dialogLines[currentLine].StartsWith("ar-"))
        {
            currentLine++;
            AR.SetActive(true);

            
        }
    }
}
