using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Windows;

public class EnemyManager : IA_stats
{
    public float timer;

    private void Update()
    {
        timer = timer + Time.deltaTime;
    }
    public void incomingAttack(float dmg)
    {
        getDamage(dmg);
        if (checkAlive())
        {
            dropItem();
            Destroy(gameObject);
        }
    }

    public float makeDamage()
    {
        if (timer >= 1f)
        {
            timer = 0f;
            return attack;
        }
        else return 0;
    }
    public void initStat(float _hp, float _maxhp, float _attack)
    {
        setVariables(_hp, _maxhp, _attack);
    }

    public void dropItem()
    {
        GameObject Drop = DropItemManager.staticDropManager.getRandomDrop();
        Drop.transform.position = transform.position;
        Instantiate(Drop, DropItemManager.staticDropManager.DropContainer.transform);
    }
}

