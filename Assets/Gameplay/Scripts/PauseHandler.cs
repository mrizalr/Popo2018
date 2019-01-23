using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseHandler : MonoBehaviour {

	public static bool gameIsPaused = false;

	public GameObject pauseMenuUI;
	public GameObject pauseMenuButton;
	public Button panelInput;
	public Animator anim;
	public Animator pauseAnim;

	void Start(){
		GameObject panelInput = GameObject.Find ("PanelInput");
		anim = panelInput.GetComponent<Animator> ();
		pauseAnim = pauseMenuUI.GetComponent<Animator> ();
		gameIsPaused = false;
		pauseMenuUI.SetActive (false);
	}

	public void pauseButtonAction(){
		if (gameIsPaused) {
			Resume ();
		}
		else if (!gameIsPaused) {
			Paused ();
		}
	}

	public void Paused(){
		pauseMenuUI.SetActive (true);
		pauseAnim.Play ("Pause_anim");
		anim.Play ("Out_animation");
		Time.timeScale = 0f;
		gameIsPaused = true;
	}

	public void Resume(){
		Time.timeScale = 1f;
		pauseAnim.Play ("Resume_anim");
		if (!panelInput.playStatus) {
			anim.Play ("In_animation");
		}
		gameIsPaused = false;
	}

	public void backToMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene("menu");
	}

	public void QuitGame(){
		Debug.Log ("Quitting game ...");
		Application.Quit ();
	}
}
