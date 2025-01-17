﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject player;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start(){
        /*
        Cursor.lockState =  CursorLockMode.Locked;
        Cursor.visible = true;
        */
    }

    void Update () {
        transform.LookAt(player.transform);
        //fps();
    }

    void fps(){
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
