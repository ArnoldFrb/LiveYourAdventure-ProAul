using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [Header("Settings Health")]
    public Text health;
    public Image Ihealth;
    public float healths;
    public GameObject Target;
    public Button ToRevive;
    public GameObject PointToRevive;
    public Text GameOver;

    Vector3 position;

    private void Start()
    {
        position = PointToRevive.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "";
        GameOver.text = "";
        Ihealth.fillAmount = healths;
        ToRevive.gameObject.SetActive(false);

        if (healths < 0.0001)
        {
            health.text = "ESTAS MUERTO...";
            GameOver.text = "GAME OVER";
            ToRevive.gameObject.SetActive(true);
        }
    }

    public void ToReviveButtom()
    {
        GameOver.text = "";
        Target.transform.position = position;
        ToRevive.gameObject.SetActive(false);
        healths = 1;
        Ihealth.fillAmount = 1;
    }
}
