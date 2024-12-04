using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Script : MonoBehaviour
{
    //Initialize floats that will determine projectile speed and lifetime
    [SerializeField] //<-------- Alows for the below variable to be edited in the Unity inspector
    float projectileSpeed;
    [SerializeField]
    float projectileLifeTime;

    private void Awake()
    {
        //When this object is created in the project call waitToTerminate Corroutine
        StartCoroutine(waitToTerminate());
    }
    private void FixedUpdate()
    {
        //Every fixed update this projectile moves along it's Z axis by projectileSpeed * Time.deltaTime
        transform.position += transform.TransformDirection(Vector3.forward) * projectileSpeed * Time.deltaTime;
    }

    IEnumerator waitToTerminate()
    {
        //Wait for projectileLifeTime seconds and then destroy this projectile
        yield return new WaitForSeconds(projectileLifeTime);
        Destroy(gameObject);
    }
}
