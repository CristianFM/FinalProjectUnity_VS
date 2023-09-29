using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWeapon : WeaponStats
{

    // Start is called before the first frame update
    void Start()
    {
        setStats(1,3f,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.tag == "enemy")
        {
            other.gameObject.GetComponent<EnemyManager>().incomingAttack(attack);
        }
    }
}
