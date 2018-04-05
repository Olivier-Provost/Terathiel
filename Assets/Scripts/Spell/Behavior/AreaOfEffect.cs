using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class AreaOfEffect : AbilityBehaviors {

    private const string aBname = "Area of effect";
    private const string aBdescription = "An area of damage!";
    private const BehaviorStartTimes startTime = BehaviorStartTimes.End; //on impact

    
    private float BaseEffectDamage;

    public AreaOfEffect( float bd) : base(new BasicObjectInformation(aBname, aBdescription), startTime)
    {

        BaseEffectDamage = bd;
    }

    public override void PerformBehavior(GameObject playerObj, GameObject objHit)
    {
       
        //apply dommage but how
       
    }

   
}
