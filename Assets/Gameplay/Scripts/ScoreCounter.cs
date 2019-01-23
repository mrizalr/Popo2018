using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public Text textScore;
	public Button playStat;
	public LevelManager gameOver;
	[HideInInspector]
	public int Score;

	// Update is called once per frame
	void Update () {
		if (playStat.playStatus == true && gameOver.isGameOver == false) {
			textScore.enabled = true;
		}
		else {
			textScore.enabled = false;
		}

		textScore.text = Score+"";
	}
}
