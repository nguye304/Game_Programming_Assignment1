﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    private Vector3 rotationX;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {

        //transform.LookAt(target, Vector3.up);
        transform.position = target.position + offset;
        //rotationX = transform.localEulerAngles.y + Input.GetAxis("");
     
	}
}
