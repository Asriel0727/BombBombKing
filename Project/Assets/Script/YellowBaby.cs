using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBaby : PlayerAttribute
{
    public override int InitLife()
    {
        return playerLife = 2;
    }

    public override int InitBomb()
    {
        return bombNum = 1;
    }
    public override int InitBombRange()
    {
        return bombRange = 1;
    }

    public override float InitSpeed()
    {
        return speed = 100f;
    }

    

    public override bool CheckBoom(bool check)
    {
        canDropBombs = check;
        return canDropBombs;
    }
}
