﻿using UnityEngine;
using System.Collections;

public class turRot : MonoBehaviour {
    public float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * (Speed * Time.deltaTime));

    }
}
