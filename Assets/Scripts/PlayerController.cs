﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 playerspeed;
    private float movementspeed=0.2f;
    public float jumpForce;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(movementspeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            saltar();

    }
    private void saltar()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}

