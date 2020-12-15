using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text health;
    public int healths = 1000;

    // Update is called once per frame
    void Update()
    {
        health.text = "VIDA: 1000/" + healths;

        if(healths < 1)
        {
            health.text = "ESTAS MUERTO...";
        }

    }
}
