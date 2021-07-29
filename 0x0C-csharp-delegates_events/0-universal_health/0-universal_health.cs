﻿using System;

///<summary>Player class.</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Player class constructor.</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }
    ///<summary>Prints health of player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
}