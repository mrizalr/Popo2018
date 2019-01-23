using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectiveScore : MonoBehaviour {
	int scoreValue = 10;

	public ScoreCounter scoreCounter;

	// Update is called once per frame
	void Update () {
		if (!PauseHandler.gameIsPaused) {
			transform.Rotate (4, 4, 4);	
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.transform.tag == "Player") {
			GameObject scoreManager = GameObject.Find ("ScoreManager");
			ScoreCounter scoreCounter = scoreManager.GetComponent<ScoreCounter> ();
			scoreCounter.Score += scoreValue;
			Destroy (gameObject);
		}
	}
}
