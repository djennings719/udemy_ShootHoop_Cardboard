﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float rotationSpeed = 2.5f;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.localRotation *= Quaternion.Euler(0, mouseX, 0);
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.rotation *= Quaternion.Euler(-mouseY, 0, 0);
    }
}