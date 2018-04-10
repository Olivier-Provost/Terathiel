using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager {

    #region singleton
    private static PlayerManager instance;

    private PlayerManager() { }

    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
                instance = new PlayerManager();

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

    public void NextTurn(float _turn)
    {
        if (_turn > 1)
            players[GameManager.Instance.GetCurrentPlayer()].UpdateCoins(GV.NEW_TURN_COINS);
    }

}
