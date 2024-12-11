using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public Transform M_Player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = M_Player.position;
    }


}