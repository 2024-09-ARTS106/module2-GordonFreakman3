using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    //Defines Spawnable Object
    [SerializeField]// <--- Allows the below variable to be edited in the Unity Inspector
    GameObject spawnableObject;
    [SerializeField]
    float timeBetweenSpawn = 2;
    [SerializeField]
    bool readyToSpawn;
    float coolDown;

    private void Awake()
    {
        // when this object is loaded into the project, set coolDown to timeBetweenSpawn and set ready to spawn to false
        coolDown = timeBetweenSpawn;
        readyToSpawn = false;
    }
    private void Update()
    {
        //if cooldDown is less than or equal to 0 Set readToSpawn to true
        if (coolDown <= 0)
        {
            coolDown = timeBetweenSpawn;
            readyToSpawn = true;
        }
        else {
        //Counts down the cool down based on the projects Time Scale
            coolDown -= 1 * Time.deltaTime;
        }
        // if readyToSpawn is true call the method SpawnObject
        if (readyToSpawn)
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
       // Spawn the object and set ready to spawn to false
        Instantiate(spawnableObject,transform.position,transform.rotation);
        readyToSpawn = false;
    }
}
