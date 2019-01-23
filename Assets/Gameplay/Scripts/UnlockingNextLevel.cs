using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingNextLevel : MonoBehaviour {

    private string nameOfThisLevel;


	// Use this for initialization
	void Start () {
        nameOfThisLevel = LevelName.levelName;
        //Debug.Log(LevelLockStatus+"."+nameOfThisLevel+"_Status");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
