using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgres : MonoBehaviour
{
    [SerializeField] private int _addHitPointEnemy;
    private int _levelCount;

    void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameProgres>().Length;
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetAddHitPointEnemy()
    {
        return _addHitPointEnemy;
    }

    public int GetLevelCount()
    {
        return _levelCount;
    }

    public void AddCountLevel()
    {
        _addHitPointEnemy++;
        _levelCount++;
    }
}
