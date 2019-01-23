using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public GameObject player;
	public PlayerBehaviour pb;
	public CameraFollow cf;
	public GameObject gameOverPanel;
	public PauseHandler pauseHandler;

	public bool isGameOver = false;

	public void GameOver(){
		if (!isGameOver) {
			pb.GetComponent<PlayerBehaviour> ().enabled = false;
			cf.GetComponent<CameraFollow> ().enabled = false;
			isGameOver = true;
			Destroy (player);
			gameOverPanel.SetActive (true);
			pauseHandler.pauseMenuButton.SetActive (false);
		}
	}

	public void Restart(){
		SceneManager.LoadScene ("Gameplay");
	}

	public void loadScene (string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
