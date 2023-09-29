using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    private EnemyManager _manager;

    // Start is called before the first frame update
    void Start()
    {
        _manager = GetComponent<EnemyManager>();
        _manager.initStat(5f,5f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void death()
    {
        Destroy(gameObject);
    }
}
