using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemy : MonoBehaviour
{
    public GameObject Target;
    public NavMeshAgent agent;

    public float distance;
    public Health healthScript;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(Target.transform.position);
            agent.speed = 5;
        }
        else
        {
            agent.speed = 0;
        }

        if(Vector3.Distance(Target.transform.position, transform.position) <= 2.5)
        {
            healthScript.healths -= 5;
        }
    }
}
