using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour{

    public float max_health = 100f;
    public float current_Health;
    public GameObject healthbar;
    public float calc_health;
    
    public GameObject go;

    void initializeHealth()
    {
        current_Health = go.GetComponent<Player>().getHealth();
    }
	
	// Update is called once per frame
	void Update () {
        
        calc_health = current_Health/max_health;
        SetHealthBar(calc_health);

	}
    

    public void SetHealthBar(float myHealth)
    {

        healthbar.transform.localScale = new Vector3(healthbar.transform.localScale.x, myHealth, healthbar.transform.localScale.z);

    }


}

