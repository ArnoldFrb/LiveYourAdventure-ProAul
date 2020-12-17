using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPet : MonoBehaviour
{
    [Header("Settings IA Pet")]
    public GameObject Target;
    public NavMeshAgent agent;
    public Animator Anim;
    public float speed;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(Target.transform.position);
            agent.speed = speed;
            
        }
        else
        {
            agent.speed = 0;
        }

        if (Vector3.Distance(Target.transform.position, transform.position) > agent.stoppingDistance + 0.3)
        {
            RunTrue();
        }
        else
        {
            RunFalse();
            agent.speed = 0;
        }
    }

    void RunTrue()
    {
        Anim.SetBool("Run", true);
    }

    void RunFalse()
    {
        Anim.SetBool("Run", false);
    }
}
