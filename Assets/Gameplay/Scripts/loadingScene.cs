using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class loadingScene : MonoBehaviour {

	public void LoadingScene(){
		if (EventSystem.current.currentSelectedGameObject.name == "Play Button") {
			SceneManager.LoadScene ("MainMenu");
		}else if (EventSystem.current.currentSelectedGameObject.name == "Shop Button") {
			Debug.Log ("open Shop");
		}else if (EventSystem.current.currentSelectedGameObject.name == "Help Button") {
			Debug.Log ("open Help");
		}else if (EventSystem.current.currentSelectedGameObject.name == "Quit Button") {
			Debug.Log ("Quit");
			Application.Quit ();
		}
	}
}
