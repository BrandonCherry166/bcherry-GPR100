using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalScore : MonoBehaviour
{
    public static int finalScore;
    public TextMeshProUGUI finalText;

    private void Update()
    {
        finalText.text = "Final Score: " + finalScore.ToString();
    }
}
