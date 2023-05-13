using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = 50;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, 0);
    }
}
