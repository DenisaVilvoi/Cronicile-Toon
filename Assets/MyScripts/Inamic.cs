using System;
using UnityEngine;

public class Inamic
{
    private string name;
    private int hp;

    public Inamic(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
    public string getname()
    {
        return name;
    }
    public int gethp()
    {
        return hp;
    }
    public void DamageEnemy(int damage)
    {
        this.hp -= damage;
    }
}