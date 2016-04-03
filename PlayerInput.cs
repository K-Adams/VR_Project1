using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public Transform movement;
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
		verticalIncrement = translationSpeed * vertical * Time.deltaTime;
		movement.Translate (new Vector3 (horizontalIncrement, 0, verticalIncrement), Space.Self);


	}

	private bool connected = false;
	IEnumerator CheckForControllers()
	{
		while(true)
		{
			var controllers = Input.GetJoystickNames();
			if (!connected && controllers.Length > 0)
			{
				connected = true;
				Debug.Log("Connected");
			}
			else if (connected && controllers.Length == 0)
			{
				connected = false;
				Debug.Log("Disconnected");
			}
			yield return new WaitForSeconds(1f);
		}
	}
	void Awake()
	{
		StartCoroutine(CheckForControllers());
	}
}
