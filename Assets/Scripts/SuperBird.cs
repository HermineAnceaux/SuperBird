using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBird : MonoBehaviour
{
    Rigidbody rb;
    public float jumpPower = 3f;
    public float forwardSpeed = 2f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.right * forwardSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        print("GAME OVER");
    }
}
