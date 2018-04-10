using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    Ability selectedAbiltity;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Input.GetMouseButtonDown(0);
        //Input.mousePosition;

	}

    public void SpellButtonPressed(string spell)
    {
        GV.SPELL_TYPE spellEnum = (GV.SPELL_TYPE)System.Enum.Parse(typeof(GV.SPELL_TYPE), spell);


        selectedAbiltity = AbilityManager.Instance.SelectAbility(spellEnum);

        Debug.Log("spell type working " + spell.ToString());
    }

}
