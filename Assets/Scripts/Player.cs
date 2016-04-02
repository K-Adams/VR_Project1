using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hitTarget(Transform target)
	{
		score += 1.0f;
		Debug.Log ("Target hit");

	}
}
