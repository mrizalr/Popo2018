using UnityEngine;

public class CameraFollow : MonoBehaviour {
	
	private float smoothSpeed = 0.125f;
	private int rotateSpeed = 5;
	public Animator anim;

	public Transform target;
	public Vector3 offset;
	public Button playStat;

	private float timer = 1.5f;
	private float timerCountdown;

	void Start(){
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (playStat.playStatus == true) {
			if (anim != null) {
				anim.enabled = true;
				anim.Play ("camera_anim");
			}
			timerCountdown += Time.deltaTime;
			if (timerCountdown >= timer) {
				cameraFollow ();
			}
		}
	}

	void cameraFollow(){
		Destroy (anim);
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;
		transform.eulerAngles = new Vector3 (30, 0, 0);

		transform.LookAt (target);
		Quaternion targetRotation = Quaternion.LookRotation (target.transform.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);	

		//var lookPos = target.position - transform.position;
		//lookPos.y = -0.5f;
		//var rotation = Quaternion.LookRotation(lookPos);
		//transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotateSpeed);	
	}
}
