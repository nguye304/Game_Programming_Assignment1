using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLR : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.right * speed);
    }
}
