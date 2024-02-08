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
        transform.Rotate(transform.forward, UnityEngine.Random.Range(1, 359));
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.up * max_speed * Time.deltaTime;
    }
    private (float,float) GetCamBounds()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        (float widthAbs, float heightAbs) CamBounds = (width/2, height/2);
        return CamBounds;
    }
    private bool IsNearEdge()
    {
        (float widthAbs,float heightAbs) CamBounds = GetCamBounds();

        if ( Mathf.Abs(transform.position.x) > CamBounds.widthAbs*0.9f || Mathf.Abs(transform.position.y) > CamBounds.heightAbs * 0.9f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        IsNearEdge();
    }
}
