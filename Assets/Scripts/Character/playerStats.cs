using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    [SerializeField] public float hpMax, hp;
    [SerializeField] public int lv, xp, xpCap, def;
    [SerializeField] public bool dead;

    public void instanceStats(float _hpMax, int _def)
    {
        hpMax = _hpMax;
        hp = hpMax;
        def = _def;
        lv = 1;
        xp = 0;
        xpCap = 10;
        changeLifeUIVariable();
        changeXpUIVariable();
        
    }
    public void gainXp(int _xp)
    {
        xp += _xp;
        if(xp >= xpCap)
        {
            lvUp();
        }
        changeXpUIVariable();
    }
    public void lvUp()
    {
        if (xp >= xpCap)
        {
            xp -= xpCap;
            lv++;
            xpCap = lv * 10;
            changeXpUIVariable();
            InterfaceManager.staticInterfaceManager.setLvText(lv);
            InterfaceManager.staticInterfaceManager.interactLvUpMenu();
        }
    }
    public void hpDamageCalc(float dmg)
    {
        hp -= dmg;
        checkAlive();
        changeLifeUIVariable();
    }

    public void checkAlive()
    {
        if(hp <= 0)
        {
            dead = true;
        }
    }

    public void recoverHp(float recoverValue)
    {
        hp += recoverValue;

        if(hp >= hpMax)
        {
            hp = hpMax;
        }

        changeLifeUIVariable();
    }

    public void changeLifeUIVariable()
    {
        InterfaceManager.staticInterfaceManager.setUIHpVariable(hp, hpMax);
    }
    public void changeXpUIVariable()
    {
        InterfaceManager.staticInterfaceManager.setUIXpVariable(xp, xpCap);
    }

}
