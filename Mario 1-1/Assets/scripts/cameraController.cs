﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 position;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}

    void Update()
    {
        
    }
    // Update is called once per frame
    void LateUpdate () {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
