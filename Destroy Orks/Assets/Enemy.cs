using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int enemyPower;

    public void AddEnemyPower(int addEnemyPower)
    {
        Debug.Log(enemyPower);
        enemyPower += addEnemyPower;
    }
}
