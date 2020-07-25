using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed;
    public float flapHeight;
    public GameObject pipe_up;
    public GameObject pipe_down;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BuildLevel();
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
        }

        if (transform.position.y > 60 || transform.position.y < -6)
        {
            Death();
        }
        BuildLevel();
    }

    public void Death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
        BuildLevel();
    }

    public void BuildLevel()
    {
        Instantiate(pipe_down, new Vector3(15, 3), transform.rotation);
        Instantiate(pipe_up, new Vector3(15, -5), transform.rotation);

        Instantiate(pipe_down, new Vector3(18.25f, 2), transform.rotation);
        Instantiate(pipe_up, new Vector3(18.2f, -5.85f), transform.rotation);

        Instantiate(pipe_down, new Vector3(12, 4), transform.rotation);
        Instantiate(pipe_up, new Vector3(12, -3), transform.rotation);

        Instantiate(pipe_down, new Vector3(18.3f, 3), transform.rotation);
        Instantiate(pipe_up, new Vector3(18, -5), transform.rotation);
    }
}
