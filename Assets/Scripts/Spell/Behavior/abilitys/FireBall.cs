using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall :Ability {
    //ranged, at the start, maxdistance,requires a atarget
    private const string aName = "FireBall";
    private const string aDescription = "A firey mass who make several damage";
    private const float actionPointCost = 3f;
    private const float rangeOfAction = 6f;
    private const float BAseEffectDamage = 10f;
   


    public FireBall(List<string> validTargets): base(new BasicObjectInformation(aName,aDescription,actionPointCost,rangeOfAction), validTargets)
    {

       
      
    }
	

}
