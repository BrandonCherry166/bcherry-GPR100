using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI text;
    private void Update()
    {
        text.text = "Score: " +  score.ToString();  
    }
}
