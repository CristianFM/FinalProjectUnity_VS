using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogic : SpawnManager
{
    //[SerializeField] private GameObject enemy;
    public SpawnManager _spawnManager;

    public bool isColliding;
    // Start is called before the first frame update
    void Start()
    {
        isColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacule")
        {
            isColliding = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Obstacule")
        {
            isColliding = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Obstacule")
        {
            isColliding = true;
        }
    }
}
