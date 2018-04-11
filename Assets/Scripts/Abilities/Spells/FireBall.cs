using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall :Ability {
    //ranged, at the start, maxdistance,requires a atarget
    private const string aName = "FIREBALL";
    private const string aDescription = "A firey mass who make several damage";
    private const float actionPointCost = 3f;
    private const float rangeOfAction= 2;
    private const float BAseEffectDamage=2;


    public override void UsedAbility(Vector3 location)
    {
        if (CheckValid(location))
        {
            GameObject go= new GameObject(); //gridtest.instance.getobjatloc
            go.GetComponent<Player>().ap -= actionPointCost;
            go.GetComponent<Player>().health-=BAseEffectDamage;
        }
    }
    public FireBall(List<string> validTargets): base(new BasicObjectInformation(aName,aDescription,actionPointCost,rangeOfAction), validTargets)
    {
        Debug.Log("spell type working Fireball ! ");
    }
	

}
