using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopDownPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5.0f;
    public Score score;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
  

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput, yInput) * speed;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("It works");
        collision.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-2.0f, 2.0f), 0);
        //score = score + 10;
    }
}
