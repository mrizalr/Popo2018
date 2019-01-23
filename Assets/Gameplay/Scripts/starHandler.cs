using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starHandler : MonoBehaviour {

	[SerializeField]
    private GameObject[] starChild;

	Image myImage1;
	Image myImage2;
	Image myImage3;
	public Sprite starImage;

	// Use this for initialization
	void Start () {
		myImage1 = starChild[0].GetComponent<Image> ();
		myImage2 = starChild[1].GetComponent<Image> ();
		myImage3 = starChild[2].GetComponent<Image> ();

		myImage1.sprite = starImage;
		myImage2.sprite = starImage;
		myImage3.sprite = starImage;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}