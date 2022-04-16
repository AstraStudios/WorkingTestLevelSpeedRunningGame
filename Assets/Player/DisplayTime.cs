using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{

    public Text displayText;
    public float highscoreForDisplay;

    // Start is called before the first frame update
    void Start()
    {
        highscoreForDisplay = PlayerPrefs.GetFloat("highscore");

        displayText.text = highscoreForDisplay.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
