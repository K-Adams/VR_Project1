using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public Transform movement;
	public Camera camera;
	float translationSpeed = 90.0f;
	float horizontal;
	float vertical;

	// Use this for initialization
	void Start () {
		horizontal = Input.GetAxis("JoyStickHorizontal");
		vertical = Input.GetAxis("JoyStickVertical");
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalIncrement;
		float verticalIncrement;


			horizontalIncrement = translationSpeed * horizontal * Time.deltaTime;
			//Debug.Log (horizontalIncrement);
			verticalIncrement = translationSpeed * vertical * Time.deltaTime;
			//Debug.Log (verticalIncrement);
			movement.Translate (new Vector3 (horizontalIncrement, 0, verticalIncrement), Space.Self);


	}
}
