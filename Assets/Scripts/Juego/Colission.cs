using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        {
            Destroy(gameObject);

            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Obstaculo_Cubo(1)")
        {
            Destroy(gameObject);

            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Obstaculo_Cubo(2)")
        {
            Destroy(gameObject);

            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Obstaculo_Esfera")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Obstaculo_Esfera(1)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Obstaculo_Esfera(2)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Obstaculo_Esfera(3)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lost");
        }
        if (col.gameObject.name == "Prefab(clone)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lost");
        }






    }
}
