﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleController : MonoBehaviour {

    private GameObject wristBone_L;
    private GameObject wristBone_R;
    private Kyle kyle;

    // Use this for initialization
    void Start () {
        this.kyle = new Kyle(GameObject.Find("Left_Shoulder_Joint_01"), GameObject.Find("Right_Shoulder_Joint_01"));
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.kyle.currentMode = PlayerControlMode.MoveLeftHand;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.kyle.currentMode = PlayerControlMode.MoveRightHand;
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.kyle.moveHandUp();
        }else if (Input.GetKey(KeyCode.S))
        {
            this.kyle.moveHandBottom();
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.kyle.moveHandRight();
        }else if (Input.GetKey(KeyCode.A))
        {
            this.kyle.moveHandLeft();
        }
    }
}
