using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemyAdvanced : MonoBehaviour
{
    [Header("Settings IA Basic")]
    public GameObject Target;
    public NavMeshAgent agent;
    public float speedEnemy;
    public int damage;
    public float distance;

    [Header("Settings Health")]
    public Health healthScript;

    [Header("Settings IA Passive")]
    public int time;
    public bool timeOfTurn;
    public float y;

    // Update is called once per frame
    void FixedUpdate()
    {
        //IA BASIC
        if (Vector3.Distance(Target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(Target.transform.position);
            agent.speed = speedEnemy;
        }
        else
        {
            //IA PASSIVE
            time += 1;
            transform.Translate(transform.forward * speedEnemy * Time.fixedDeltaTime);
            transform.Rotate(new Vector3(0, y, 0));

            if (time >= Random.Range(100, 2500))
            {
                Turn();
                time = 0;
                timeOfTurn = true;
            }

            if (timeOfTurn)
            {
                if(time >= Random.Range(10, 30))
                {
                    y = 0;
                    timeOfTurn = false;
                }
            }
        }

        //IA BASIC
        if (Vector3.Distance(Target.transform.position, transform.position) <= 2.5)
        {
            healthScript.healths -= damage;
        }
    }

    //IA PASSIVE
    public void Turn()
    {
        y = Random.Range(-3, 3);
    }
}
