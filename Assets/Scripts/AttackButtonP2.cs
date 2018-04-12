using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButtonP2 : MonoBehaviour {

    GameObject p2;

    private void Start()
    {
        p2 = GameObject.FindGameObjectWithTag("Player2");

    }
    public void OnClickAttack()
    {
        Debug.Log("buttonPressed");
        p2.GetComponent<PlayerHardcode>().TakesDamage(5);
        Debug.Log("health " + p2.GetComponent<PlayerHardcode>().health);

    }
}
