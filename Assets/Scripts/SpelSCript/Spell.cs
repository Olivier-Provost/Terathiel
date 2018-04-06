using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell
{
    public string spellName;
    public int ActionPointCost;
    public int range;

    public Spell(string spellname, int _acCost, int _range)
    {
        spellName = spellname;
        ActionPointCost = _acCost;
        range = _range;
    }

    public virtual void Cast()
    {

    }
}
