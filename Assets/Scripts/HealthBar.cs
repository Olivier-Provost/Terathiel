using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour{

    public float max_health = 20f;
    public float current_Health;
    public GameObject healthbar;
    public float calc_health;
    public GameObject go;

    private void Start()
    {
        current_Health = go.GetComponent<PlayerHardcode>().health;
        max_health = GV.PLAYERS_MAX_LIFE;
    }

    // Update is called once per frame
    void Update()
    {
        current_Health = go.GetComponent<PlayerHardcode>().health;
        Debug.Log("curent health : " + current_Health + " maxHealth : " + max_health);
        if (max_health != 0 && current_Health >= 0)
            calc_health = current_Health / max_health;
        SetHealthBar(calc_health);
    }

    public void SetHealthBar(float myHealth)
    {
        healthbar.transform.localScale = new Vector3(healthbar.transform.localScale.x, myHealth, healthbar.transform.localScale.z);
    }


}

