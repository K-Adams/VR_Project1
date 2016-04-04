using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;  //must include this to execute events and have access to event classes
public class GazeCursor : MonoBehaviour {

	public Camera cam; //must assign the camera in the inspector that will do the raycasting.  Make sure this camera is a physics raycaster if you want cursor clicks to work too.
	public float defaultDistance=1; //how far away is the cursor if nothing is intersected?

	void Update () {
		if (cam == null) {  //don't execute if failed to assign the camera
			Debug.Log ("camera not assigned to gaze cursor");
			return;
		} else {
			Cursor.lockState = CursorLockMode.Locked; 
			Cursor.visible = false;
		}

		//do a quick raycast through the camera center
		GameObject hitObject = null;
		RaycastHit rh;
	
			this.transform.position = cam.transform.position + cam.transform.forward * defaultDistance; //otherwise set to default.

		

		//do a click action if we are over an object and the user hits the E Key on the keyboard or clicks
		if(Input.GetKeyDown (KeyCode.E) || Input.GetMouseButtonDown(0)){
			PointerEventData pointer = new PointerEventData(EventSystem.current);
			if(hitObject != null){
				Debug.Log ("here"+hitObject.name);
				ExecuteEvents.Execute(hitObject,pointer,ExecuteEvents.pointerClickHandler);
			}
		}
	}
}
