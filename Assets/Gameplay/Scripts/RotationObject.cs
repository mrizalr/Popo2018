﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour {
	private float speed = 1f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, speed, 0);
	}
}
