﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

	private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
	private bool isDraging = false;
	private Vector2 startTouch, swipeDelta;

	private void Update(){
		tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;

		if (Input.GetMouseButtonDown(0)) {
			tap = true;
			isDraging = true;
			startTouch = Input.mousePosition;
		}
		else if (Input.GetMouseButtonUp(0)) {
			isDraging = false;
			Reset();	
		}

		swipeDelta = Vector2.zero;
		if (isDraging) {
			if (Input.GetMouseButton(0)) {
				swipeDelta = (Vector2)Input.mousePosition-startTouch;
			}

			if (swipeDelta.magnitude > 125) {
				float x = swipeDelta.x;
				float y = swipeDelta.y;

				if (Mathf.Abs (x) > Mathf.Abs (y)) {
					if (x < 0)
						swipeLeft = true;
					else
						swipeRight = true;
				}
				else {
					if (y < 0)
						swipeDown = true;
					else
						swipeUp = true;
				}
				Reset ();
			}
		}
	}

	private void Reset(){
		startTouch = swipeDelta = Vector2.zero;
		isDraging = false;
	}

	public Vector2 SwipeDelta{ get { return swipeDelta; } }
	public bool SwipeLeft { get{ return swipeLeft; } }
	public bool SwipeRight { get{ return swipeRight; } }
	public bool SwipeUp { get{ return swipeUp; } }
	public bool SwipeDown { get{ return swipeDown; } }

}
