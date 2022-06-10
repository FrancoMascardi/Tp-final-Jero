using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text txt;
    float currentTime;
    void Update()
    {
        currentTime = Time.timeSinceLevelLoad;

        txt.text = Mathf.Floor(currentTime).ToString();
        if (currentTime > 10)
        {
            SceneManager.LoadScene("Win");
        }
    }

    
}