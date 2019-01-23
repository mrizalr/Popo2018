using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public WheelCollider WheelFL;
	public WheelCollider WheelFR;
	public WheelCollider WheelBL;
	public WheelCollider WheelBR;

	public GameObject FL;
	public GameObject FR;
	public GameObject BL;
	public GameObject BR;

	public float topSpeed = 250f;
	public float maxTorque = 200f;
	public float maxSteerAngle = 45f;
	public float maxBrakeTorque = 2200;
	public float currentSpeed;

	private float Forward;
	private float Turn;
	private float Brake;

//	private Rigidbody rb;

	// Use this for initialization
	void Start () {
//		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Forward = Input.GetAxis ("Vertical");
		Turn = Input.GetAxis ("Horizontal");
		Brake = Input.GetAxis ("Jump");

		WheelFL.steerAngle = maxSteerAngle * Turn;
		WheelFR.steerAngle = maxSteerAngle * Turn;

		currentSpeed = 2 * 22 / 7 * WheelBL.radius * WheelBL.rpm * 60 / 1000; // formula for calculating speed in kmph

		if (currentSpeed < topSpeed) {
			WheelBL.motorTorque = maxTorque * Forward;
			WheelBR.motorTorque = maxTorque * Forward;
		}

		WheelBL.brakeTorque = maxBrakeTorque * Brake;
		WheelBR.brakeTorque = maxBrakeTorque * Brake;
		WheelFL.brakeTorque = maxBrakeTorque * Brake;
		WheelFR.brakeTorque = maxBrakeTorque * Brake;
	}

	void Update()
	{
		Quaternion flq;
		Vector3 flv;
		WheelFL.GetWorldPose (out flv, out flq);
		FL.transform.position = flv;
		FL.transform.rotation = flq;

		Quaternion frq;
		Vector3 frv;
		WheelFR.GetWorldPose (out frv, out frq);
		FR.transform.position = frv;
		FR.transform.rotation = frq;

		Quaternion blq;
		Vector3 blv;
		WheelBL.GetWorldPose (out blv, out blq);
		BL.transform.position = blv;
		BL.transform.rotation = blq;

		Quaternion brq;
		Vector3 brv;
		WheelBR.GetWorldPose (out brv, out brq);
		BR.transform.position = brv;
		BR.transform.rotation = brq;
	}
}
