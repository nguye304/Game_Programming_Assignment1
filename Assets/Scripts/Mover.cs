using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(10, 0, speed);
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);    
    }
}
