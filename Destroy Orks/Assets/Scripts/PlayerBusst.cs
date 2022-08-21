using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IPlayerDamage
{
    int GetPlayerDamage();
}

public class PlayerBusst : MonoBehaviour , IPlayerDamage
{
    [SerializeField] private int _playerDamage;

    private void AddPower(int busst)
    {
        _playerDamage += busst;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Busst>())
        {
            AddPower(other.GetComponent<Busst>().GetBusst());
        }
    }

    public int GetPlayerDamage()
    {
        return _playerDamage;
    }
}
