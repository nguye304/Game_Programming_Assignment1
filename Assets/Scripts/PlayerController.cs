using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 direction;
    public Vector3 velocity;
    public Vector3 fallingVelocity;
    public float speed;
    public float gravity;
    public float jumpHeight;
    public LayerMask ground;
    public Transform feet;
    private CharacterController controller;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = 10.0f;
        gravity = 9.8f;
        fallingVelocity = Vector3.zero;
        direction = Vector3.zero;
        jumpHeight = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");//edit >>project settings >>input
        direction.z = Input.GetAxis("Vertical");
        //direction.y = Input.GetAxis("Jump");
        direction = direction.normalized;
        velocity = direction * speed;
        controller.Move(velocity * Time.deltaTime);
        if (direction != Vector3.zero)
        {
            transform.forward = direction;
            Debug.Log(direction);
        }
        bool isGround = Physics.CheckSphere(feet.position, 0.1f, ground, QueryTriggerInteraction.Ignore);
        if (isGround)
            fallingVelocity.y = 0f;
        else
            fallingVelocity.y -= gravity * Time.deltaTime;
       
        if (Input.GetButtonDown("Jump") && isGround)//if want a swim or double jump get rid of isground
        {
            fallingVelocity.y = Mathf.Sqrt(gravity * jumpHeight);
        }
        controller.Move(fallingVelocity);
    }
}