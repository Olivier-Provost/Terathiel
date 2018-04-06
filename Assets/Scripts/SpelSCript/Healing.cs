using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : Ability
{
    private const string aName = "Healing";
    private const string aDescription = "A healing spell to grow up your life ";
    private const float actionPointCost = 3f;
    private const float rangeOfAction = 6f;
    private const float BAseEffectHealing = 8f;

    public Healing(List<string> validTargets) :base(new BasicObjectInformation(aName, aDescription, actionPointCost, rangeOfAction), validTargets)
    {
        Debug.Log("spell type working Healing !");
    }
}
