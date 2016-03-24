using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public Transform gun;//where things will shoot from nozzle z direction
	public GameObject projectile;
	public float exitSpeed = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void fire()
	{
		GameObject projectile = GameObject.Instantiate<GameObject> (projectile);

		projectile.transform.position = gun;
		projectile.transform.rotation = gun;
		projectile.transform.localScale = Vector3.one;

		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = exitSpeed * gun.forward;

		//projectile.GetComponent<Projectile>().owner

	}
}
