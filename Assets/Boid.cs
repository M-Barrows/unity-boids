using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boid : MonoBehaviour
{
    public Rigidbody2D rb;
    public int max_speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.transform.Rotate(rb.transform.forward, UnityEngine.Random.Range(1, 359));
    }
    private void FixedUpdate()
    {
        rb.velocity = rb.transform.up * max_speed * Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
