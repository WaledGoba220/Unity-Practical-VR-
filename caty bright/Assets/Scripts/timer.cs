using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float Gtime = 60;
    public float Rtime;
    public Text Gtext;

    void Start()
    {
       
        Rtime = Gtime;
        Gtext = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Rtime -= Time.deltaTime;
        if (Rtime <= 0)
        {
            EndGame();
        }
        updateTime();
    }

    void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    void updateTime()
    {
        int minutes = Mathf.FloorToInt(Rtime / 60);
        int seconds = Mathf.FloorToInt(Rtime / 60);
        string timestring = string.Format("{0:00}:{1:00}", minutes, seconds);
        
        Gtext.text = "timer:" + timestring;
    }
}