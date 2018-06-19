using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;

    private bool ismovingright = false;
    private bool canmove = true;


    [SerializeField]
    float speed = 4f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canmove)
        {
            ChangeBoolean();
            ChangeDirection();
        }
        if (Physics.Raycast(this.transform.position, Vector3.down * 2) == false)
        {
            FallDown();
        }
    }

    private void FallDown()
    {
        canmove = false;
        rb.velocity = new Vector3(0f, -4f, 0f);
    }

    private void ChangeBoolean()
    {
        ismovingright = !ismovingright;
    }
    private void ChangeDirection()
    {
        if (ismovingright)
        {
            rb.velocity = new Vector3(speed, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, speed);
        }
    }
}
