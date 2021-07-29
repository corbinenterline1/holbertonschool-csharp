using System;

///<summary>Player class.</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    EventHandler<CurrentHPArgs> HPCheck;

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
        this.HPCheck += CheckStatus;
        this.status = String.Format("{0} is ready to go!", this.name);
    }
    ///<summary>Prints health of player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    ///<summary>Method to calculate Player's damage taken.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;
        float newHp = hp - damage;
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(newHp);
    }

    ///<summary>Method to calculate Player's health restored.</summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0f)
            heal = 0f;
        float newHp = hp + heal;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(newHp);
    }

    ///<summary>Method to validate the HP of the player.  HP can't be below 0 or above maxHp.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp >= maxHp)
            hp = maxHp;
        else
            hp = newHp;
        OnCheckStatus(this, new CurrentHPArgs(this.hp));
    }

    ///<summary>Method to apply the modifier.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue * 0.5f);
        else if (modifier == Modifier.Base)
            return (baseValue);
        else
            return (baseValue * 1.5f);
    }

    ///<summary>Checks the status of the Player's current health.</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            this.status = String.Format("{0} is in perfect health!", name);
        else if (e.currentHp >= maxHp * 0.5f)
            this.status = String.Format("{0} is doing well!", name);
        else if (e.currentHp >= maxHp * 0.25f)
            this.status = String.Format("{0} isn't doing too great...", name);
        else if (e.currentHp > 0)
            this.status = String.Format("{0} needs help!", name);
        else
            this.status = String.Format("{0} is knocked out!", name);
        Console.WriteLine(this.status);
    }

    ///<summary>Low health warning!</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health is low!");
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }

    ///<summary>Calls health warning before status check.</summary>
    public void OnCheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp < maxHp * 0.25)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}

///<summary>Value Modifier.</summary>
public enum Modifier
{
    ///<summary>Half of base value.</summary>
    Weak,
    ///<summary>Base value.</summary>
    Base,
    ///<summary>1.5 times base value.</summary>
    Strong
}

///<summary>Delegate to calculate Player's health.</summary>
public delegate void CalculateHealth(float damage);

///<summary>Delegate to calculate Modifier.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class CurrentHPArgs : EventArgs
{
    public float currentHp {get;}

    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}