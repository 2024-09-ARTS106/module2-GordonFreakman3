using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Full_Auto_Fire_Script : MonoBehaviour
{
    [SerializeField]
    float rateOfFireInSeconds;
    [SerializeField]
    float coolDown;
    [SerializeField]
    private GameObject projectile;
    private void Awake()
    {
        coolDown = rateOfFireInSeconds;
    }

    private void Update()
    {
        if (coolDown <= 0 && Input.GetButton("Fire1"))
        {
            fireProjectile();
            coolDown = rateOfFireInSeconds;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            coolDown = 0;
        }
            coolDown -= 1 * Time.deltaTime;
    }

    void fireProjectile()
    {
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
