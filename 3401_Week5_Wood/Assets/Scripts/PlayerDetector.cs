﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, 5))
            Debug.Log(gameObject.transform.name);
        if (Physics.Raycast(transform.position, fwd, 5) == false)
            Debug.Log("NOTHING AHEAD");
    } 
        }


