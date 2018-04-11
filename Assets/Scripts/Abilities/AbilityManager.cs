using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager
{

    Dictionary<GV.SPELL_TYPE, Ability> spellBook;

    #region singleton
    private static AbilityManager instance;

    private AbilityManager() {
        Initialize();
    }

    public static AbilityManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AbilityManager();
            }
            return instance;
        }
    }
    #endregion

    private void Initialize() {
        
        spellBook = new Dictionary<GV.SPELL_TYPE, Ability>();

        spellBook.Add(GV.SPELL_TYPE.HEALING, new Healing(new List<string>() {"player"}));
        spellBook.Add(GV.SPELL_TYPE.FIREBALL, new FireBall(new List<string>() { "player" }));
        spellBook.Add(GV.SPELL_TYPE.SPAWN, new SumonSpell(new List<string>() { "nothing" }));


    } 

    public Ability SelectAbility(GV.SPELL_TYPE monType)
    {
        return spellBook[monType];
    }

}
