using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	public PlayerBehaviour pb;
	public bool playStatus = false;
	public char[] temp;
	public GameObject leftImg;
	public GameObject jumpImg;
	public GameObject rightImg;
	public Transform iconImg;
	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;
	public Animator anim;

	int xAxis = -415; //526
	int yAxis = 218;
	int xRange = 160;
	int yRange = 100;

	List<char> tempList = new List<char>();

	private string name;

	void Start () {
		playStatus = false;
		anim.Play ("In_animation");
	}

	public void ButtonOnClicked(Button button){
		name = EventSystem.current.currentSelectedGameObject.name;		
		//Debug.Log (name);
		if (name == "Left") {
			tempList.Add ('L');
			GameObject go = Instantiate (leftImg, new Vector3(xAxis,yAxis,0), Quaternion.identity) as GameObject;
			go.transform.SetParent (iconImg.transform, false);
			if (xAxis < 385) {
				xAxis += xRange;
			} 
			else if (xAxis >= 385) {
				xAxis = -415;
				yAxis -= yRange;
			}
		}
		else if (name == "Jump") {
			tempList.Add ('J');
			GameObject go = Instantiate (jumpImg, new Vector3(xAxis,yAxis,0), Quaternion.identity) as GameObject;
			go.transform.SetParent (iconImg.transform, false);
			if (xAxis < 385) {
				xAxis += xRange;
			} 
			else if (xAxis >= 385) {
				xAxis = -415;
				yAxis -= yRange;
			}
		}
		else if (name == "Right") {
			tempList.Add ('R');
			GameObject go = Instantiate (rightImg, new Vector3(xAxis,yAxis,0), Quaternion.identity) as GameObject;
			go.transform.SetParent (iconImg.transform, false);
			if (xAxis < 385) {
				xAxis += xRange;
			} 
			else if (xAxis >= 385) {
				xAxis = -415;
				yAxis -= yRange;
			}
		}

		else if (name == "Clear") {
			tempList.Clear ();
			foreach (Transform child in iconImg) {
				GameObject.Destroy (child.gameObject);
			}
			xAxis = -415;
			yAxis = 223;
		}

		temp = tempList.ToArray ();
		/*if(temp.Length <= 0)
			print("kosong bang");
		for (int i = 0; i < temp.Length; i++) {
			if (temp.Length>0)
				print (temp [i] + ", ");
		}*/

		if (name == "Action") {
			playStatus = true;
			pb.direction = temp;
			anim.Play ("Out_animation");
		}
	}
}
