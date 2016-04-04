using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Gun : MonoBehaviour {

	public Transform gun;//where things will shoot from nozzle z direction
	public GameObject projectilePrefab;
    public GameObject barrierPrefab;
	public float exitSpeed = 100;
    public int startAmmo = 100;
    public int currentAmmo;
    public Slider AmmoSlider;
    bool isFired = false;
    bool displayLabel = false;
    public Text Reload;
    public Text ScoreText;

    Player player;
    

    // Use this for initialization
    void Start () {
	    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }


    void Awake()
    {
        currentAmmo = startAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmmo <= 0)
        {
            Debug.Log("Reload Ammo");
            FlashLabel();
            if (displayLabel == true)
            {

                Reload.text = "RELOAD (-50)";
                if (Input.GetKeyDown(KeyCode.R) && player.currentScore >= 50)
                {
                    player.currentScore -= 50;
                    displayLabel = false;
                    Reload.text = "";
                    currentAmmo = startAmmo;
                    
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.X) || Input.GetMouseButtonDown(0))
            {
                fire();
                if (isFired)
                {
                    currentAmmo--;
                    AmmoSlider.value = currentAmmo;
                    Debug.Log("ammo --");
                    isFired = false;

                }
            }
        }


        // BARRIER 
        if (player.currentScore >= 500 && Input.GetKeyDown(KeyCode.F))
        {
            dropBarrier();
            player.currentScore -= 500;
        }
     


    }

    /* ------------------------------------------------------------
    Drop a barrier Object */
    public void dropBarrier()
    {
        GameObject barrier = GameObject.Instantiate<GameObject>(barrierPrefab);
        barrier.transform.position = gun.position;
        barrier.transform.rotation = gun.rotation;
        barrier.transform.localScale = Vector3.one;
    }



    /* ------------------------------------------------------------
    SHOOT BULLETS */
    public void fire()
	{
        isFired = true;
		GameObject projectile = GameObject.Instantiate<GameObject> (projectilePrefab);

		projectile.transform.position = gun.position;
		projectile.transform.rotation = gun.rotation;
		projectile.transform.localScale = Vector3.one;

		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = exitSpeed * gun.forward;

		//projectile.GetComponent<Projectile>().owner

	}

    public void FlashLabel()
    {

        // flash of  Reload label on   

        displayLabel = true;


    }
}

