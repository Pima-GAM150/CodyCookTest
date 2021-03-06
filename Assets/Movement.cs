﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed;

	public float jumpPower;
	// Use this for initialization
	void Start ()
	{
		speed = 8f;
		jumpPower = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal")* speed * Time.deltaTime, Input.GetAxis("Jump") * jumpPower * Time.deltaTime, 0f);
	}
}
