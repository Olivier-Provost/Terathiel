using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public float max_health = 100f;
    public float current_Health = 0f;
    public GameObject healthbar;
    public float calc_health;

	// Use this for initialization
	void Start () {
        current_Health = max_health;
        InvokeRepeating("DecreasedHealth", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DecreasedHealth()
    {
        current_Health -= 2;
        calc_health = current_Health / max_health;
        SetHealthBar(calc_health);
    }
    public void SetHealthBar(float myHealth)
    {
        healthbar.transform.localScale = new Vector3(healthbar.transform.localScale.x, myHealth, healthbar.transform.localScale.z);
    }
}

