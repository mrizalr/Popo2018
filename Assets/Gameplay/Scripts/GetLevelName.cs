using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GetLevelName : MonoBehaviour {
	public string levelNameClicked;

	public void OnClick(){
		levelNameClicked = EventSystem.current.currentSelectedGameObject.name;
		LevelName.levelName = levelNameClicked;
		SceneManager.LoadScene ("Gameplay");
	}
}
