using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.up * .5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.up * -.5f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.right * .5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.right * -.5f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.rotation += .1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.rotation -= .1f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.gravityScale += .01f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && rb.gravityScale >= .01f)
        {
            rb.gravityScale -= .01f;
        }
    }
}
