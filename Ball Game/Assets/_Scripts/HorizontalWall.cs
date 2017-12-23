﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalWall : MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;
	public Transform position2;
	public Vector3 newPosition;
	public string state;
	public float smooth;
	public float resetTime;

	void Start(){
		ChangeTarget ();
	}

	void FixedUpdate(){
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);

	}

	void ChangeTarget(){
		if (state == "Move1") {
			state = "Move2";
			newPosition = position2.position;
		} else if (state == "Move2") {
			state = "Move1";
			newPosition = position1.position;
		} else if (state == "") {
			state = "Move2";
			newPosition = position2.position;
		}
		Invoke ("ChangeTarget", resetTime);
	}
}
