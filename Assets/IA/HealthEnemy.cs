using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : MonoBehaviour
{
    [Header("Settings Health")]
    public Image Ihealth;
    public float healths;
    public GameObject Enemy;

    // Update is called once per frame
    void Update()
    {
        Ihealth.fillAmount = healths;

        if (healths < 0.0001)
        {
            Enemy.gameObject.SetActive(false);
        }
    }
}
