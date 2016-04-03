using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
public int startHealth = 100;
public int currentHealth;
public Slider healthSlider;
public Image damageImage;
//public float flashSpeed = 5f;
//public Color FlashColor = new Color(1f,0f,0f,0.1f);

Animator anim;
AudioSource playerAudio;
//PlayerMovement playerMovement;

bool isDead;
bool damaged;

void Awake()
{
anim = GetComponent <Animator>();
//playerAudio = GetComponent<AudioSource<();
//playerMovement = GetComponent<PlayerMovement>();
currentHealth = startHealth;


}

void Update()
{
	//currentHealth--;
	//damaged = true;
if(damaged)
{
	
//damageImage.color = FlashColor;
takeDamage(20);
damaged = false;
}
else
{
//damageImage.color =Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
}
//damaged = false;

}

public void takeDamage(int amount)
{
currentHealth -= amount;
healthSlider.value = currentHealth;

//playerAudio.Play();

if(currentHealth <= 0 && !isDead)
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