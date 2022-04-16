using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    float currentTime;
    public int startMinutes;

    public static float highscore;

    void Start()
    {
        currentTime = startMinutes * 60;

        PlayerPrefs.SetFloat("highscore", 30);
    }

    private void Update()
    {
        stopWatchRunning();
    }

    private void OnDestroy()
    {
        // check if the highscore is less then 
        if (currentTime < PlayerPrefs.GetFloat("highscore"))
        {
            highscore = currentTime;
            PlayerPrefs.SetFloat("highscore", highscore);
            PlayerPrefs.Save();
        }
    }

    public void stopWatchRunning()
    { 
        
        currentTime = currentTime + Time.deltaTime;

        timerText.text = currentTime.ToString();
    }

    
}
