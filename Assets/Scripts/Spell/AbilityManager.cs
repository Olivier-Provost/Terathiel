using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager
{

    Dictionary<SpellType, Ability> spellBook;
    #region
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

    public enum SpellType
    {
        FireBall , Healing, Spawn
    }

    private void Initialize() {
        
        spellBook = new Dictionary<SpellType, Ability>();

        spellBook.Add(SpellType.Healing, new Healing(new List<string>() {"player"}));
        spellBook.Add(SpellType.FireBall, new FireBall(new List<string>() { "player" }));
        spellBook.Add(SpellType.Spawn, new SumonSpell(new List<string>() { "nothing" }));


    } 

    public Ability SelectAbility(SpellType monType)
    {

        return spellBook[monType];
    }

}
