using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beastborn
{
    public int type;
    private int basicCon = 2;

    public int conReturn()
    {
        return basicCon;
    }

    public int typeReturn()
    {
        return type;
    }

    public int typeCalc(Player playerID)
    {
        switch (type)
        {
            case 0:
                return playerID.GetStr() + 1;
            case 1:
                return playerID.GetDex() + 1;
            case 2:
                return playerID.GetInt() + 1;
            case 3:
                return playerID.GetWis() + 1;
            case 4:
                return playerID.GetCha() + 1;
        }

        return 0;
    }

    public void setType(int sType)
    {
        type=sType;
    }
}
