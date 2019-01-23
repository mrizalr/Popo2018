using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeView : MonoBehaviour {

	public Transform cameraObject;

	private Vector3 startPosition;

	private void Update(){
		startPosition = GetPosition ();

		if (Input.GetMouseButton (0)) {
			Debug.Log ("x "+(int)startPosition.x);
			Debug.Log ("y "+(int)startPosition.z);
			cameraObject.transform.position = startPosition;
		}
	}

	Vector3 GetPosition(){
		startPosition = Input.mousePosition;
		startPosition.z = 10;
		return cameraObject.GetComponent<Camera> ().ScreenToWorldPoint(startPosition);
	}
}
