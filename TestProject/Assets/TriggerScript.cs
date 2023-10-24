using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Score score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f), 0);
        score.score += 166;
        FinalScore.finalScore += 166;
    }
}
