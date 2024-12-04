using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health=100;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision detected");
        if (collision.gameObject.CompareTag("Projectile"))
        {
            health = health - 5;
            Destroy(collision.gameObject);
        }
        if (health <= 0)
        {
            //die code here

        }
    }

}
