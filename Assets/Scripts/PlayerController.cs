﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 playerspeed;
    private float movementspeed=0.2f;
    public float jumpForce;
    Rigidbody rb;
    float multiplicadorEscala;

    public int maxJumps;
    int hasJump;


    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
        multiplicadorEscala = -1;

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
     
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale += new Vector3(0, 0.5f, 0) * multiplicadorEscala;
            multiplicadorEscala *= -1;
        }
      
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Pista")
        {
            hasJump = maxJumps;
        }
    }
   
}

