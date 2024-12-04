using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semi_Auto_Fire_Script : MonoBehaviour
{
    //instantiates projectile GameObject
    [SerializeField]
    GameObject projectile;
    private void Update()
    {
        //when the user uses the Fire1 button (Left Mouse Click) create gameObject projectile
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
