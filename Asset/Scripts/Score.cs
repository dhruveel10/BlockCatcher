using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text score;
    public static int rScore = 0;
    public static int gScore = 0;
    public static int bScore = 0;
    public static int bdScore = 0;
    int finalScore = 0;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    public void Update()
    {
        finalScore = rScore + gScore + bScore + bdScore;
        score.text = finalScore.ToString();
    }

}
