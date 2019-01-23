using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrigger : MonoBehaviour {

	public Color grayColor, greenColor;
	Color currentColor;
	MeshRenderer myRenderer;

	void Start(){
		myRenderer = GetComponent<MeshRenderer> ();
		myRenderer.material.color = grayColor;
		currentColor = grayColor;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Turn-Check") {
			currentColor = greenColor;
		}
	}

	void Update(){
		myRenderer.material.color = Color.Lerp (myRenderer.material.color, currentColor, 0.1f);
	}
}
