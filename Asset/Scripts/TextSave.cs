using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class TextSave : MonoBehaviour
{
   
    void Start()
    {
        CreateText();
    }

    public void CreateText()
    {
        string path = Application.dataPath + "/Log.txt";
        if(!File.Exists(path))
        {
            File.WriteAllText(path, "Summary\n");
        }

        string content = "\nDate: " + System.DateTime.Now + "\n" + 
            "Red Container Points = " + Score.rScore + "\t" + "Green Container Points = " + Score.gScore + "\t" + 
            "Blue Container Points = " + Score.bScore + "\t" + "Bricks Missed Points = " + Score.bdScore + "\n" + 
            "Total Correct Matches = " + Counter.rightMatchTotal + "\t" + "Total Incorrect Matches = " + Counter.wrongMatchTotal + "\n"; 
        File.AppendAllText(path, content);
    }
    
}
