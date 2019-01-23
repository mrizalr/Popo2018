using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSlider : MonoBehaviour {

	public GameObject[] levelGroup;
	int  i = 0;
	bool nextButtonClicked, prevButtonClicked;
	string btnClickedName;
	// Use this for initialization
	void Start () {
		levelGroup [i].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (nextButtonClicked && i<levelGroup.Length-1) {
			levelGroup [i].SetActive (false);
			i++;
			levelGroup [i].SetActive (true);
		}
		else if (prevButtonClicked && i > 0) {
			levelGroup [i].SetActive (false);
			i--;
			levelGroup [i].SetActive (true);
		}
		nextButtonClicked = prevButtonClicked = false;
	}

	public void onClick(){
		btnClickedName = EventSystem.current.currentSelectedGameObject.name;
		if (btnClickedName == "Prev Button") {
			prevButtonClicked = true;
		}else if (btnClickedName == "Next Button") {
			nextButtonClicked = true;
		}
        else if (btnClickedName == "Back Button")
        {
            SceneManager.LoadScene("menu");
        }
	}
}
