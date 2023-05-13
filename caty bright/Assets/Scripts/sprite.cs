using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite Bigm;
    public GameObject sm;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = Resources.Load("PlayerAnimator") as RuntimeAnimatorController;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {


            sm.GetComponent<SpriteRenderer>().sprite = Bigm;
            animator.Play("player-run-1");
            Destroy(this.gameObject);

        }
    }
}