using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchToZoom : MonoBehaviour {

	Camera mainCamera;

	float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;

	Vector2 firstTouchPrevPos, secondTouchPrevPos;

	float zoomModifierSpeed = 1f;

	// Use this for initialization
	void Start () {
		mainCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 2) {
			Touch firstTouch = Input.GetTouch (0);
			Touch secondTouch = Input.GetTouch (1);

			firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
			secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

			touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
			touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

			zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;

			if (touchesPrevPosDifference > touchesCurPosDifference && mainCamera.transform.position.y < 50f) {
				mainCamera.transform.position += new Vector3(0, zoomModifierSpeed, 0);
			}
			if (touchesPrevPosDifference < touchesCurPosDifference && mainCamera.transform.position.y > 5f) {
				mainCamera.transform.position -= new Vector3(0, zoomModifierSpeed, 0);
			}
		}
	}
}
