using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager {

    #region singleton
    private static UIManager instance;

    private UIManager() { }

    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = new UIManager();

            return instance;
        }
    }
    #endregion singleton

    Ability selectedAbiltity;

    public void SpellButtonPressed(string spell)
    {
        GV.SPELL_TYPE spellEnum = (GV.SPELL_TYPE)System.Enum.Parse(typeof(GV.SPELL_TYPE), spell);


        selectedAbiltity = AbilityManager.Instance.SelectAbility(spellEnum);

        Debug.Log("spell type working " + spell.ToString());
    }

    public void EndTurn()
    {

    }
}
