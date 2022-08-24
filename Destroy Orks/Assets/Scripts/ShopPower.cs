using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPower : MonoBehaviour
{
    [SerializeField] private int _costBusst;
    [SerializeField] private int _addToCost;
    [SerializeField] private int _addBust;
    private Bank _bank;
    private PlayerBusst _playerBusst;

    private void Start()
    {
        _bank = FindObjectOfType<Bank>();
        _playerBusst = FindObjectOfType<PlayerBusst>();
    }

    public void BuyBusst()
    {
        if(_costBusst <= _bank.GetMoney())
        {
            _bank.Deposit(_costBusst);
            _playerBusst.AddPower(_addBust);
            _costBusst += _addToCost;
        }
    }
}