using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IPlayerDamage
{
    int GetPlayerDamage();
}

public class PlayerBusst : MonoBehaviour , IPlayerDamage
{
    [SerializeField] private int currentPower;

    private void AddPower(int busst)
    {
        currentPower += busst;
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
        return currentPower;
    }
}
