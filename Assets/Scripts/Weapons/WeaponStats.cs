using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    public int code;
    public float attack;
    public int lv;

    internal void Start()
    {

    }

    public void setStats( int _code, float _attack, int _lv)
    {
            code = _code;
            attack = _attack;  
            lv = _lv;
    }
}
