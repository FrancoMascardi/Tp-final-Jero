using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Object")
        {
            Destroy(col.gameObject);
        }
    }
    private float velocidad = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        loop();
    }
    private void loop()
    {

        transform.position += (transform.forward * velocidad * Time.deltaTime);
        if (transform.position.y < -30)
        {
            transform.Translate(Vector3.right * 1 * Time.deltaTime);
        }

    }

     //Update is called once per frame
  
}
