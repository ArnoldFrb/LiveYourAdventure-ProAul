using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAAnimal : MonoBehaviour
{
    [Header("Settings IA Animals")]
    public int time;
    public bool timeOfTurn;
    public float y;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //IA PASSIVE
        time += 1;
        transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
        transform.Rotate(new Vector3(0, y, 0));

        if (time >= Random.Range(100, 2500))
        {
            Turn();
            time = 0;
            timeOfTurn = true;
        }

        if (timeOfTurn)
        {
            if (time >= Random.Range(10, 30))
            {
                y = 0;
                timeOfTurn = false;
            }
        }
    }

    //IA PASSIVE
    public void Turn()
    {
        y = Random.Range(-3, 3);
    }
}
