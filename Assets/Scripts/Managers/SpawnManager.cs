using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> enemyList;
    public List<Transform> spawnsList;
    public GameObject EnemiesContainer;
    public float timer;
    public float gameTimer;
    public int enemyNumber;
    public bool debugSpawn;
    // Start is called before the first frame update
    void Start()
    {
        enemyNumber = 1;
        chargeSpawns();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (debugSpawn)
        {
            if (timer >= 3)
            {
                timer = 0;
                spawnEnemy();
            }
        }
        setEnemyNumber();
    }
    public void chargeSpawns()
    {
        foreach(Transform child in transform)
        {
            spawnsList.Add(child);
        }
    }
    public void setEnemyNumber()
    {
        enemyNumber = GameManager.staticGameMananger.setAmountEnemies();
    }
    public void spawnEnemy()
    {
        Transform TemporalSpawnUnable = null;

        for (int i = 0; i <= enemyNumber ; i++){

            Transform aux = getRandomSpawn();
                if (TemporalSpawnUnable != aux)
                {
                    if (!aux.GetComponent<SpawnLogic>().isColliding)
                    {
                        Instantiate(enemyList[0], aux.position, Quaternion.identity, EnemiesContainer.transform);
                        TemporalSpawnUnable = aux;
                    }
                }
            i++;
        }
    }
    public Transform getRandomSpawn()
    {
        int random = Random.Range(0, spawnsList.Count - 1);
        return spawnsList[random];
    }
}
