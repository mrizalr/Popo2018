using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishTrigger : MonoBehaviour {

	public PlayerBehaviour pb;
	public GameObject player;
	public GameObject finishedPanel;
	public Text scoreToDisplayText;
	public ScoreCounter scoreCounter;
	public PauseHandler pauseHandler;

	void Start(){
		finishedPanel = GameObject.Find("FinishPanel");
		finishedPanel.SetActive (false);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Popo") {
			player = GameObject.Find ("Popo");
			pb = player.GetComponent<PlayerBehaviour> ();
			//finishedPanel = GameObject.Find("FinishPanel");

			pb.enabled = false;
			finishedPanel.SetActive (true);
			GameObject canvas = GameObject.Find ("Canvas");
			pauseHandler = canvas.GetComponent<PauseHandler> ();
			pauseHandler.pauseMenuButton.SetActive (false);

			scoreToDisplayText = GameObject.Find ("scoreValue").GetComponent<Text>();
			GameObject scoreManager = GameObject.Find ("ScoreManager");
			ScoreCounter scoreCounter = scoreManager.GetComponent<ScoreCounter> ();
			scoreToDisplayText.text = scoreCounter.Score+""; 
		}
	}
}
