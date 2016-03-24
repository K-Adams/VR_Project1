using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	/*public Transform turntable;
	public float rotationSpeed = 90.0f;
	public float pitchSpeed = 90.0f;
	public float currentPitch = 50.0f; 
	public float pitchMax = 60.0f;
	
	float powerMin = 10.0f;
	float powerMax = 100.0f;
	float powerIncrement = 1.0f;
	public float currentpower = 50.0f;
	*/
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//control the turning of the turntable (a and d to rotate ccw and cw)

		//contol the pitch of the cannon with w and s (for up and down)
		/*
		bool ccwInput = Input.GetKey (KeyCode.A);
		bool cwInput = Input.GetKey (KeyCode.D);
		bool pitchUpInput = Input.GetKey (KeyCode.W);
		bool pitchDownInput = Input.GetKey (KeyCode.S);
		//Debug.Log(ccwInput);

		float turntableVelocity = 0.0f;
		if (ccwInput) {
			turntableVelocity -= rotationSpeed;
		}
		if (cwInput) {
			turntableVelocity += rotationSpeed;
		}
		float turntableIncrement = rotationSpeed * Time.deltaTime;
		turntable.Rotate (new Vector3 (0, turntableIncrement, 0), Space.Self);

		float pitchVelocity = 0.0f;
		if (pitchUpInput) {
			pitchVelocity -= pitchSpeed;

		}
		if (pitchDownInput) {
			pitchVelocity += pitchSpeed;

		}

		float pitchIncrement = pitchVelocity * Time.deltaTime;
		currentPitch += pitchIncrement;
		cannon.transform.localRotation = Quaternion.AngleAxis(currentPitch, );
		if(currentPitch > pitchMax){
		}*/
		if (Input.GetKeyDown (KeyCode.Space)) {
			AK.fire ();
		}
		
		
		//Cannon power level increase/decrease capsule speed
		//Mouse movement along the x and y axis
	/*
		if (powerUpInput) {
			cannon.exitSpeed -= powerIncrement;
		}

		if (powerDownInput) {
			cannon.exitSpeed += powerIncrement;
		}

		if (cannon.exitSpeed > powerMax) {
			currentpower = powerMax;
		}

		if (cannon.exitSpeed < powerMin) {
			currentpower = powerMin;
		}
			
		float mouseMovementX = Input.GetAxis ("Mouse X");
		float mouseMovementY = Input.GetAxis ("Mouse Y");

		transform.Rotate (0, mouseMovementX, 0, Space.Self);
		//camera.Rotate (-mouseMovementY, 0, 0, Space.Self);
*/

	}
}
