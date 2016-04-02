using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

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


		if (collision.transform.name == "Terrain") {
            Destroy(gameObject, 2f);
            Debug.Log ("ground hit");
		}

		if (collision.transform.name == "ZomBearPrefab") {
            Destroy(gameObject, 2f);
            Debug.Log ("target hit");
		
		}
	}

}
