using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{

    public GameObject bala;
    public GameObject spawnPoint;
    public Transform apuntadorTR;
    Rigidbody rbBala;
    public float fuerzaDisparo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GameObject clon;
            clon = Instantiate(bala);
            rbBala = clon.GetComponent<Rigidbody>();
            clon.transform.rotation = apuntadorTR.rotation;
            clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward;
            rbBala.AddForce(clon.transform.up * fuerzaDisparo, ForceMode.Impulse);
            rbBala.AddForce(apuntadorTR.up * fuerzaDisparo, ForceMode.Impulse);
            Destroy(clon, 1);
        }
        
    }    
}
