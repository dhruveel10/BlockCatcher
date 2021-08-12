using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] Canvas CounterCanvas;
    [SerializeField] Canvas gameOverCanvas;
    float timeLeft = 120;
    public Text counter;
    public Text rightMatch;
    public Text wrongMatch;
    public static int rightMatchTotal = 0;
    public static int wrongMatchTotal = 0;

    public TextSave text;
    bool texts = false;

    private void Awake()
    {
        CounterCanvas.enabled = true;
        gameOverCanvas.enabled = false; 
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        counter.text = timeLeft.ToString("0");
        if (timeLeft <= 0)
        {
            CounterCanvas.enabled = false;
            Time.timeScale = 0;
            GameOver();
        }
    }

    void GameOver()
    {
            rightMatch.text = "Right Matches: " + rightMatchTotal;
            wrongMatch.text = "Wrong Matches: " + wrongMatchTotal;
            gameOverCanvas.enabled = true;

        if (texts == false)
        {
            text.CreateText();
            texts = true;
        }
    }

}
