using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public float max_health = 100f;
    public float current_Health;
    public GameObject healthbar;
    public float calc_health;
    public float min_health = 0f;
    public GameObject go;
	// Use this for initialization
	void Start () {
        current_Health =  go.GetComponent<Player>().health;

        // current_Health = max_health;
        //InvokeRepeating("DecreasedHealth", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

        calc_health = current_Health; // max_health
        SetHealthBar(calc_health);
	}

   /* void DecreasedHealth()
    {
        if(current_Health>min_health)
                    current_Health -= 4;

        calc_health = current_Health / max_health;
        SetHealthBar(calc_health);
    }*/
    public void SetHealthBar(float myHealth)
    {
        healthbar.transform.localScale = new Vector3(healthbar.transform.localScale.x, myHealth, healthbar.transform.localScale.z);
    }
}

