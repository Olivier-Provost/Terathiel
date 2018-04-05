using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObjectInformation {

    private string name;
    private string description;
    private float actionPointCost;
    private float rangeOfAction;

    public BasicObjectInformation(string _name)
    {
        name = _name;
    }

    public BasicObjectInformation(string _name, string _description, float _APC, float _ROA)
    {
        actionPointCost = _APC;
        rangeOfAction = _ROA;
        name = _name;
        description = _description;
    }

    public string AbilityName
    {
        get { return name; }
    }

    public string AbilityDescription
    {
        get { return description; }
    }
    public float AbilityActionPoint
    {
        get { return actionPointCost; }
    }
    public float AbilityRange
    {
        get { return  rangeOfAction; }
    }
}
