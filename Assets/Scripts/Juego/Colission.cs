using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstaculo_Cubo")
            Destroy(gameObject);
        if (col.gameObject.name == "Obstaculo_Esfera")
            Destroy(gameObject);
        if (col.gameObject.name == "Prefab")
            Destroy(gameObject);


    }
}
