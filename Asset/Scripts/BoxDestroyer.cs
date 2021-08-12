using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroyer : MonoBehaviour
{
    string currentText = "Brick Missed";
    public CommentScript goodComments;

    public Score score;
    int counter = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score.bdScore += -2;
        Destroy(collision.gameObject);
        GameOverCanvas.wrongMatchTotal = counter++;
        Counter.wrongMatchTotal += 1;
        goodComments.DisplayMessages(currentText);
    }
}
