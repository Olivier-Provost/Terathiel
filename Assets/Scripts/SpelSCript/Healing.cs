using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : Ability
{
    private const string aName = "Healing";
    private const string aDescription = "A healing spell to grow up your life ";
    private const float actionPointCost = 3f;
    private const float rangeOfAction = 6f;
    private const float baseEffectHealing = 8f;

    public override void UsedAbility(Vector3 location)
    {
        if (CheckValid(location))
        {
            GameObject go = new GameObject(); //gridtest.instance.getobjatloc
            go.GetComponent<Player>().actionPoint -= actionPointCost;
            go.GetComponent<Player>().Health += baseEffectHealing;


        }
    }

    public Healing(List<string> validTargets) :base(new BasicObjectInformation(aName, aDescription, actionPointCost, rangeOfAction), validTargets)
    {
        Debug.Log("spell type working Healing !");
    }
}
