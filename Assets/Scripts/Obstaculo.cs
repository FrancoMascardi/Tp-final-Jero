using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag== "Obstaculo_Cubo (1)")
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
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        if (transform.position.z < -30)
        {
            transform.Translate(Vector3.back * 60);
        }
        if (transform.position.y < 0.3)
        {
            transform.Translate(Vector3.up * 2);
        }

        // transform.position += (transform.forward * velocidad * Time.deltaTime);
        //if (transform.position.z < -30)
        //{
        //  transform.Translate(Vector3.right * 60);
        //}

    }

     //Update is called once per frame
  
}
