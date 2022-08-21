using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBusst : MonoBehaviour
{
    private int currentPower;

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
}
