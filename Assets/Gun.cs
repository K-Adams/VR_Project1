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
        if (Input.GetKeyDown(KeyCode.X))
        {
            fire();
        }

    }

    public void fire()
	{
        Debug.Log("FIRED");
		projectile = GameObject.Instantiate<GameObject> (projectile);

		projectile.transform.position = gun.position;
		projectile.transform.rotation = gun.rotation;
		projectile.transform.localScale = Vector3.one;

		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = exitSpeed * gun.forward;

		//projectile.GetComponent<Projectile>().owner

	}
}
