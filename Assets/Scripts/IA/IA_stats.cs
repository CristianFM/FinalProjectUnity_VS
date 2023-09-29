using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_stats : MonoBehaviour
{

    [SerializeField] public float hp, maxHp, attack;
    [SerializeField] public bool isDead;

    public void setVariables(float _hp, float _maxhp, float _attack)
    {
        hp = _hp;
        maxHp = _maxhp;
        attack = _attack;
    }


    internal void getDamage(float damage)
    {
        hp -= damage;
    }

    public bool checkAlive()
    {
        if (hp <= 0f)
        {
            return true;
        }
        else return false;
    }

}
