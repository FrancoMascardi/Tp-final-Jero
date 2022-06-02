using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollision(Collision col)
    {
        if (col.gameObject.tag=="Object")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
