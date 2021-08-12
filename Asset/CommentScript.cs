using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentScript : MonoBehaviour
{
   
    public Text displayText;

    private void Start()
    {
        displayText.enabled = false;
    }

    public void DisplayMessages(string message)
    {
        displayText.enabled = true;
        
        displayText.text = message;
    }
}
