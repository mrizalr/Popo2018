using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	//public char[] direction = new char[] {'L', 'J', 'R', 'J', 'R', 'L'};
	public char[] direction = new char[]{};
	public float moveSpeed = 2f;
	public float jumpPower = 350f;
	public GameObject[] wheel;
	public Button playStat;
	public LevelManager levelManager;

	private int i =0;
	private Rigidbody rb;
	private float timer = 1.5f;
	private float timerCountdown;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (playStat.playStatus == true) {
			timerCountdown += Time.deltaTime;
			if (timerCountdown >= timer) {
				playerMove ();
			}
			foreach (GameObject val in wheel) {
				val.transform.Rotate(new Vector3(moveSpeed,0,0));
			}
		}

		if (rb.position.y <= -0.5) {
			levelManager.GameOver ();
		}
	}

	void Update(){
		if (playStat.playStatus == true) {
			if (timerCountdown >=timer) {
				if ((Input.GetKeyDown(KeyCode.Space) || IsTapping()) && i < direction.Length) {
					if (direction [i] == 'L') {
						//moveSpeed = 0;
						transform.Rotate (0, -90, 0);
						//moveSpeed = 2f;
					} else if (direction [i] == 'R') {
						//moveSpeed = 0;
						transform.Rotate (0, 90, 0);
						//moveSpeed = 2f;
					} else if (direction [i] == 'J') {
						rb.AddForce (Vector3.up * jumpPower, ForceMode.Impulse);
					}

					i++;
				}
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.transform.tag == "Wall") {
			levelManager.GameOver ();
		}
	}

	bool IsTapping(){
		if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began) {
			return true;
		}
		return false;
	}

	void playerMove(){
		transform.Translate (0, 0, moveSpeed * Time.deltaTime);
	}
}
