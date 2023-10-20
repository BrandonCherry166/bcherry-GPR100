using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5.0f;
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
    }
}
