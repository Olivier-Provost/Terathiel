using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability {
    private BasicObjectInformation objectInfo;

    public List<string> valigTargets; // the list will have target like player or null to know if they can cast it or not

  
    public Ability(BasicObjectInformation _objectInfo,List<string>_validTargets)
    {

        objectInfo = _objectInfo;
        valigTargets = _validTargets;

    }
    
  public BasicObjectInformation AbilityInfo
    {
        get { return objectInfo;}
    }

  

    public virtual void UsedAbility()
    {
        
    }

    public bool CheckValid(Vector2Int loc)
    {
     bool isValid = true;

        //vector2int griloca = gridmanager.instance.grabLocation;
        //
        return isValid;
    }

   

}
