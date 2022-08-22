using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPower : MonoBehaviour
{
    [SerializeField] private int _costBusst;
    [SerializeField] private int _addToCost;
    [SerializeField] private int _addBust;
    private Bank bank;
    private PlayerBusst playerBusst;

    private void Start()
    {
        bank = FindObjectOfType<Bank>();
        playerBusst = FindObjectOfType<PlayerBusst>();
    }

    public void BayBusst()
    {
        if(_costBusst <= bank.GetMoney())
        {
            bank.Deposit(_costBusst);
            playerBusst.AddPower(_addBust);
            _costBusst += _addToCost;
        }
    }
}
