using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShopPower : MonoBehaviour
{
    [SerializeField] private int _costBusst;
    [SerializeField] private int _addToCost;
    [SerializeField] private int _addBust;
    private Bank _bank;
    private PlayerBusst _playerBusst;
    public UnityEvent NewCostEvent;

    private const string _savekey = "ShopSave";

    private void Awake()
    {
        Load();
    }

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
            NewCostEvent.Invoke();
            Save();
        }
    }

    public int GetCost()
    {
        return _costBusst;
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.ShopSave>(_savekey);

        _costBusst = data.costBusst;

    }

    private void Save()
    {
        SaveManager.Save(_savekey, GetSaveSnapshot());
    }

    private SaveData.ShopSave GetSaveSnapshot()
    {
        var data = new SaveData.ShopSave()
        {
            costBusst = _costBusst
        };

        return data;
    }
}
