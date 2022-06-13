using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class While : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public void CloneObject()
    {
        int contador = 0;
        while (contador < cloneAmount)
        {
            Instantiate(objectToClone, new Vector3(0,0,0), Quaternion.identity);
            contador++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
