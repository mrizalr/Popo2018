using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour {

	public CameraTest ct;
	public Transform player;
	public Button playStat;

	private Vector3 desiredPosition;
	// Update is called once per frame
	void Update () {
		if (playStat.playStatus == false) {
			if (ct.SwipeLeft) {
				desiredPosition += Vector3.left;
			}	
			if (ct.SwipeRight) {
				desiredPosition += Vector3.right;
			}	
			if (ct.SwipeUp) {
				desiredPosition += Vector3.forward;
			}	
			if (ct.SwipeDown) {
				desiredPosition += Vector3.back;
			}

			player.transform.position = Vector3.MoveTowards (player.transform.position, desiredPosition*3, 10f * Time.deltaTime);
		}
	}
}
