using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GV {

	//General
    public enum PLAYER_UNIT { PLAYER1, PLAYER2 };
    public enum ACTION_TYPE { MOVE, SPELL };
    public enum SPELL_TYPE { FIREBALL, HEALING, SPAWN };

    //Déplacement
    public static readonly string MOVING_TAG = "MovementRange";
    public static readonly string HEALING_TAG = "HealingRange";
    public static readonly string FIREBALL_TAG = "FireballRange";
    public static readonly string SPAWN_TAG = "SpawnRange";

    //Players
    public static readonly int NUMBER_OF_PLAYER = 2;
    public static readonly string PLAYER1_TAG = "Player1";
    public static readonly string PLAYER2_TAG = "Player2";
    public static readonly float PLAYERS_MAX_ACTION_POINTS = 5f;
    public static readonly float PLAYERS_MAX_LIFE = 20f;

    //Actions

    //Moving
    public static readonly int MAX_MOVING_RANGE = 5;
    public static readonly int MIN_MOVING_RANGE = 1;
    public static readonly float MOVING_COST = 1f;

    //Fireball
    public static readonly int FIREBALL_MAX_RANGE = 5;
    public static readonly int FIREBALL_MIN_RANGE = 3;
    public static readonly float FIREBALL_DAMAGE = 5f;
    public static readonly float FIREBALL_COST = 2f;

    //Heal
    public static readonly int HEALING_RANGE = 0;
    public static readonly float HEALING_AMOUNT = 3f;
    public static readonly float HEALING_COST = 2f;

    //Spawn
    public static readonly int SPAWN_MAX_RANGE = 4;
    public static readonly int SPAWN_MIN_RANGE = 3;
    public static readonly float SPAWN_COST = 3f;
}
