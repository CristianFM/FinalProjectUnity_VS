using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : playerStats
{

    private void Start()
    {
        instanceStats(5,0);
    }
    public void takeDamage(float dmg)
    {
        hpDamageCalc(dmg);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cake")
        {
            gainXp(2);
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "enemy")
        {
            Debug.Log("caca");
            takeDamage(1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            takeDamage(1);
        }
    }

}
