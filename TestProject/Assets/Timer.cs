using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 60f;
    public TextMeshProUGUI timerText;
    public SceneSwitch gameOver;

    private void Start()
    {
        currentTime = startingTime;
    }
    private void Update()
    {
        currentTime -= Time.deltaTime;
        timerText.text = "Time Remaining: " + currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            gameOver.switchScene();
        }
    }
   
 
}
