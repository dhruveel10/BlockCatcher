using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas counterCanavs;
    public Text rightMatch;
    public Text wrongMatch;
    public static int rightMatchTotal = 0;
    public static int wrongMatchTotal = 0;

    // Start is called before the first frame update
    void Awake()
    {
        gameOverCanvas.enabled = false;
    }

    void GameOver()
    {
        if(counterCanavs)
        {
            rightMatchTotal += 1;
            wrongMatchTotal += 1;
            rightMatch.text = "Right Matches: " + rightMatchTotal;
            wrongMatch.text = "Wrong Matches: " + wrongMatchTotal;
            gameOverCanvas.enabled = true;
        }
        
    }
}
