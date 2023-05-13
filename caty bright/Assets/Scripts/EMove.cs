using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMove : MonoBehaviour
{
    public Transform Lblock;
    public Transform Rblock;
    public float speed = 3;
    public bool ismoveright = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ismoveright)
        {
            transform.position = Vector2.MoveTowards(transform.position, Rblock.position, speed * Time.deltaTime);
            if (transform.position == Rblock.position)
            {
                ismoveright = false;
            }
        }
        else
        {

            transform.position = Vector2.MoveTowards(transform.position, Lblock.position, speed * Time.deltaTime);
            if (transform.position == Lblock.position)
            {
                ismoveright = true;
            }
        }
    }
}
