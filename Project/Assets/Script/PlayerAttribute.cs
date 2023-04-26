using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttribute 
{
    public int playerLife = 2;

    public int bombNum = 1;

    public int bombRange = 1;

    public float speed = 100f;

    public bool canDropBombs = true;

    public bool cantouch = true;

    public virtual int InitLife()
    {
        return playerLife;
    }

    public virtual int InitBomb()
    {
        return bombNum;
    }

    public virtual int InitBombRange()
    {
        return bombRange;
    }
    public virtual float InitSpeed()
    {
        return speed;
    }

    public virtual bool CheckBoom(bool check)
    {
        return canDropBombs;
    }

    public virtual void InitAll()
    {
        InitLife();
        InitBomb();
        InitBombRange();
        InitSpeed();
    }

    public virtual bool CheckTouch(bool check)
    {
        return cantouch;
    }

}
