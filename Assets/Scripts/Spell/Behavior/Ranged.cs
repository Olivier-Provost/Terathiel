using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : AbilityBehaviors {
    private const string name = "Ranged";
    private const string description = "A ranged Spell!";
    private const BehaviorStartTimes startTime = BehaviorStartTimes.Beginning;

    private float minDistance;
    private float maxDistance;
    public bool isRandom;
    private float lifeDistance;

	public Ranged(float _minD, float _maxD,bool _isRandom):base(new BasicObjectInformation(name,description),startTime)
    {
        minDistance = _minD;
        maxDistance = _maxD;
        isRandom = _isRandom;
    }

    public override void PerformBehavior(GameObject playerObj, GameObject objHit)
    {
      
    }

 

    public float MinDistance
    {
        get { return minDistance; }
    }

    public float MaxDistance
    {
        get { return maxDistance; }
    }
}
