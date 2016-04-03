using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public Player owner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay (contact.point, contact.normal, Color.white);
		}
			
		Debug.Log ("Collision");


		if (collision.transform.name == "ground") {
			GameObject.Destroy (this.gameObject);
			Debug.Log ("ground hit");
		}

		if (collision.transform.name == "TargetGraphic") {
			owner.hitTarget (collision.transform);
			GameObject.Destroy (this.gameObject);
			Debug.Log ("target hit");
		
		}
	}

}
