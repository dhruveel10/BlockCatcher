using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueContainer : MonoBehaviour
{
    int points;
    public Score scoreR;
    int tenCounter = 0;
    int twoCounter = 0;

    string[] messages = { "Well Done", "Woah", "Nice" };
    string[] messages2 = { "Oops", "Incorrect" };
    string currentText;
    string goodComments, badComments;
    public CommentScript Comments;

    public void Start()
    {
    //    scoreR = FindObjectOfType<Score>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Blue Box")
        {

            Destroy(collision.gameObject);
            points = 10;
            Score.bScore += 10;
            Counter.rightMatchTotal += 1;


            goodComments = messages[Random.Range(0, messages.Length)];
            Comments.DisplayMessages(goodComments);
        }
        else
        {
            Destroy(collision.gameObject);
            points = -2;
            Score.rScore += -2;
            Counter.wrongMatchTotal += 1;

            badComments = messages2[Random.Range(0, messages2.Length)];
            Comments.DisplayMessages(badComments);
        }
    }
}
