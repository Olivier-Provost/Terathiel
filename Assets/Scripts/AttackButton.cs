using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour {

     GameObject p1;

    private void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1");
        
    }
    public void  OnClickAttack()
    {
        Debug.Log("buttonPressed");
        p1.GetComponent<PlayerHardcode>().TakesDamage(5);
        Debug.Log("health " + p1.GetComponent<PlayerHardcode>().health);
        
    }
}
