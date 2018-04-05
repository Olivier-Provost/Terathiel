using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehaviors : MonoBehaviour {
    private BasicObjectInformation objectInfo;
    private BehaviorStartTimes startTime;

    public enum BehaviorStartTimes
    {
        Beginning, Middle, End
    }

    public AbilityBehaviors(BasicObjectInformation _objectInfo, BehaviorStartTimes sTime)
    {
        objectInfo = _objectInfo;
        startTime = sTime;

    }

    public virtual void PerformBehavior(GameObject playerObj, GameObject objHit)
    {
        Debug.LogWarning("Need to had behavior ");
    }

    public BasicObjectInformation AbilityBehaviorInfo
    {
        get { return objectInfo; }
    }

    public BehaviorStartTimes AbilityBehaviorStartTime
    {
        get { return startTime; }
    }
}
