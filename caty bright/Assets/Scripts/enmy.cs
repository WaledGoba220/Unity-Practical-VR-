using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enmy : MonoBehaviour
{
    public AudioClip reSound;
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D other)
    {

        //if (other.tag == "coin")
        //{
        //    scorenum += 10;
        //    Destroy(other.gameObject);
        //    AudioSource.PlayClipAtPoint(collectSound, transform.position);
        //    scoretext.text = "Score  :" + scorenum;
        //}
        if (other.tag == "E")
        {
            AudioSource.PlayClipAtPoint(reSound, transform.position);
            nextscene();
        }
       

    }

    void nextscene()
    {
        SceneManager.LoadScene(0);
    }
}
