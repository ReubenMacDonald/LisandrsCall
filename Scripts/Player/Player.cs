using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerID;
    private int strength;
    private int dexterity;
    private int constitution;
    private int intelligence;
    private int wisdom;
    private int charisma;
    private Race raceID;
    private Classes classID;

    public int GetStr()
    {
        return strength;
    }
    public int GetDex()
    {
        return dexterity;
    }
    public int GetCon()
    {
        return constitution;
    }
    public int GetInt()
    {
        return intelligence;
    }
    public int GetWis()
    {
        return wisdom;
    }
    public int GetCha()
    {
        return charisma;
    }
}
