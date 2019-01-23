using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour {
	public GameObject prefab;
	public string levelNameLoad;

	// Use this for initialization
	void Start () {
		levelNameLoad = LevelName.levelName;
		//prefab = AssetDatabase.LoadAssetAtPath ("Assets/Gameplay/Level/"+levelNameLoad+".prefab", typeof(GameObject)) as GameObject;
		prefab = Resources.Load("Level/"+levelNameLoad) as GameObject;
		GameObject go = Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		go.transform.parent = GameObject.Find ("LevelGenerator").transform;
	}

}
