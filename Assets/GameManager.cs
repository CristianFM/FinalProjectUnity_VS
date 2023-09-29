using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager staticGameMananger;

    public float gameTimer;
    public int Difficult;

    // Start is called before the first frame update
    void Start()
    {
        Difficult = 0;
        staticGameMananger = this;
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer += Time.deltaTime;
        Difficult = setAmountEnemies();
    }

    public int setAmountEnemies()
    {
        int aux = 1;
        if (gameTimer >= 10)
        { 
            aux = ((int)(gameTimer / 10));
        }
        return aux;
    }
}
