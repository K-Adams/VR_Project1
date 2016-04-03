using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public Transform gun;//where things will shoot from nozzle z direction
    public GameObject projectile;
    public float exitSpeed = 100;
    public int startAmmo = 100;
    public int currentAmmo;
    public Slider AmmoSlider;
    bool isFired = false;
    bool displayLabel = false;
    public Text Reload;

    void Awake()
    {
        currentAmmo = startAmmo;
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmmo <= 0)
        {


            Debug.Log("Reload Ammo");
            FlashLabel();
            if(displayLabel == true)
            {
                
                Reload.text = "RELOAD";
                if(Input.GetKeyDown(KeyCode.R))
                {
                    displayLabel = false;
                    Reload.text = "";
                    currentAmmo = 100;
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Space))
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
    }

    public void fire()
    {
        isFired = true;
        Debug.Log("FIRED");
        projectile = GameObject.Instantiate<GameObject>(projectile);

        projectile.transform.position = gun.position;
        projectile.transform.rotation = gun.rotation;
        projectile.transform.localScale = Vector3.one;

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = exitSpeed * gun.forward;

        //projectile.GetComponent<Projectile>().owner

    }



    public void FlashLabel()
    {

        // Fancy pants flash of label on and off   
       
            displayLabel = true;
          

    }
}
