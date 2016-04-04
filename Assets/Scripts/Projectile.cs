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
			
		if (collision.transform.name == "Terrain") {
			GameObject.Destroy (this.gameObject);
			Debug.Log ("ground hit");
		}

		if (collision.transform.name == "ZomBearPrefab") {
			GameObject.Destroy (this.gameObject);
			Debug.Log ("target hit");
		
		}
	}

}
