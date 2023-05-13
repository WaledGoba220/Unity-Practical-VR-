using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Coin : MonoBehaviour
{

    public Text scoretext;

    public int scorenum;
    public AudioClip collectSound;
    public AudioClip reSound;

    void Start()
    {
        scorenum = 0;
        scoretext.text = "Score :" + scorenum;
        winnerPanel.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "coin")
        {
            scorenum += 10;
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            scoretext.text = "Score  :" + scorenum;
        }
        if (other.tag == "re") {
            AudioSource.PlayClipAtPoint(reSound, transform.position);
            nextscene();
        } else if (other.tag == "win") {
            WinGame();
        }

    }

    void nextscene()
    {
        SceneManager.LoadScene(0);
    }
    public GameObject winnerPanel;


    public void WinGame()
    {
        winnerPanel.SetActive(true);
    }
}
