using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Score score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-2.0f, 2.0f), 0);
        score.score += 166;
    }
}
