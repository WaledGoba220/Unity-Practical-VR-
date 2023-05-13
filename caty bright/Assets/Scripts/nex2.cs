using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nex2 : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioClip musicclip;

    void start()
    {
        musicsource.clip = musicclip;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            musicsource.Play();
            Invoke("nextscene", musicclip.length);
            nextscene();


        }


    }

    void nextscene()
    {
        SceneManager.LoadScene(1);
    }
}
