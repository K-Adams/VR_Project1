using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int startHealth = 100;
    public int currentHealth;
    public int enemiesInside = 0;
    public Slider healthSlider;
    public Image damageImage;

    private int counter = 0;

    //public float flashSpeed = 5f;
    //public Color FlashColor = new Color(1f,0f,0f,0.1f);

    Animator anim;
    AudioSource playerAudio;
    //PlayerMovement playerMovement;

    bool isDead;

    void Awake()
    {
        anim = GetComponent<Animator>();
        //playerAudio = GetComponent<AudioSource<();
        //playerMovement = GetComponent<PlayerMovement>();
        currentHealth = startHealth;


    }

    void Update()
    {
        //currentHealth--;
        //damaged = true;
        counter++;
        if (counter >= 50)
        {
            counter = 0;
            if (enemiesInside > 0)
            {
                takeDamage(enemiesInside * 5);
            }
        }

    }

    public void takeDamage(int amount)
    {
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        //playerAudio.Play();

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }


    }




  




    void Death()
    {
        isDead = true;

        //anim.SetTrigger("Die");

        //playerAudio.clip = deathClip;
        //playerAudio.Play();

        //playerMovement.enabled = false;
    }

}