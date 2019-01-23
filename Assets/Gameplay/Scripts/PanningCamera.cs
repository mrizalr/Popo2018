using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanningCamera : MonoBehaviour {

	private float speed = 0.01f;
	public Button playStat;
	public CameraFollow cameraFollow;

	// Update is called once per frame
	void Update () {
		if (playStat.playStatus == false) {
			cameraFollow = GetComponent<CameraFollow> ();
			cameraFollow.anim.enabled = false;
			if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;

				transform.Translate (-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
			}		
		}
	}
}
