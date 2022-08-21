using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private bool _hasEnenie;
    private Enemy[] _enemies;

    private void OnEnable()
    {
        _enemies = GetComponentsInChildren<Enemy>();

        if (_enemies.Length != 0)
        {
            _hasEnenie = true;
        }

    }
   
    public void AddToEnemiesPower(int addBusst)
    {
        foreach(Enemy enemy in _enemies)
        {
            enemy.AddHitPoint(addBusst);
        }
    }

    public bool hasEnenie()
    {
        return _hasEnenie;
    }
}
