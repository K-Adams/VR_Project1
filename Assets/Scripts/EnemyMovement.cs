using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform garden;               // Reference to the player's position.
        EnemyHealth enemyHealth;        // Reference to this enemy's health.
        NavMeshAgent nav;               // Reference to the nav mesh agent.
        bool canMove = true;
        GameObject barrierCollision;

        void Awake ()
        {
            // Set up the references.
            garden = GameObject.FindGameObjectWithTag ("garden").transform;
            enemyHealth = GetComponent <EnemyHealth> ();
            nav = GetComponent <NavMeshAgent> ();
        }


        void Update ()
        {
            if (canMove)
            {
                transform.position = Vector3.MoveTowards(transform.position, garden.position, 1 * Time.deltaTime);

            }
            else if(barrierCollision == null)
            {
                canMove = true;
            }
            // If the enemy and the player have health left...
            // if(enemyHealth.currentHealth > 0)
            // {
            // ... set the destination of the nav mesh agent to the player.
           // nav.SetDestination (garden.position);
           // }
            // Otherwise...
           // else
           // {
                // ... disable the nav mesh agent.
           //     nav.enabled = false;
           // }
        }





        void OnCollisionEnter(Collision collision)
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                Debug.DrawRay(contact.point, contact.normal, Color.white);
            }

            if (collision.transform.name == "barrier")
            {
                barrierCollision = collision.gameObject;
                canMove = false;
            }
         
        }



    }
}