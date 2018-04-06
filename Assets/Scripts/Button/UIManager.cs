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
        AbilityManager.SpellType spellEnum = (AbilityManager.SpellType)System.Enum.Parse(typeof(AbilityManager.SpellType), spell);


        selectedAbiltity = AbilityManager.Instance.SelectAbility(spellEnum);

        Debug.Log("spell type working " + spell.ToString());
    }

}
