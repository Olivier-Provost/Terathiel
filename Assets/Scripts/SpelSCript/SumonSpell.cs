using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumonSpell : Ability
{
    private const string aName = "Sumonning";
    private const string aDescription = "A summon spell who grow a wall";
    private const float actionPointCost = 3f;
    private const float rangeOfAction = 6f;
    

    public SumonSpell(List<string> validTargets) : base(new BasicObjectInformation(aName, aDescription, actionPointCost, rangeOfAction), validTargets)
    {

    }
}
