using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coin : MonoBehaviour
{
    public Text scoretext;
    public int scorenum;
    public AudioClip collectSound;

    void Start()
    {
        scorenum = 0;
        scoretext.text = "score:" + scorenum;
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "mycoin")
        {
            scorenum += 10;
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            scoretext.text = "Score:" + scorenum;
        }

    }
}
