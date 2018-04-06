using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : Spell
{

    public Healing(string spellname, int _acCost, int _range) : base(spellname, _acCost, _range)
    {
        spellName = spellname;
        ActionPointCost = _acCost;
        range = _range;
    }
}
