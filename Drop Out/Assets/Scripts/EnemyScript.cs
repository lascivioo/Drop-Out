using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent navAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        navAgent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
