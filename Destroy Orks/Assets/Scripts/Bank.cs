using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCountMoney;
    [SerializeField] private int _countMoney;
    private const string _savekey = "BankSave";

    private void Awake()
    {
        Load();
    }

    private void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        _textCountMoney.text = _countMoney.ToString();
    }

    public int GetMoney()
    {
        return _countMoney;
    }

    public void AddMoney(int addMoney)
    {
        
        _countMoney += addMoney;
        Save();
        UpdateUI();
    }

    public void Deposit(int depositMoney)
    {
        _countMoney -= depositMoney;
        Save();
        UpdateUI();
    }

    public void GetAdsMoneyButton()
    {
        AdsManager.Instance.ShowAd(this);
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.BankSave>(_savekey);

        _countMoney = data.countMoney;
    }

    private void Save()
    {
        SaveManager.Save(_savekey, GetSaveSnapshot());
    }

    private SaveData.BankSave GetSaveSnapshot()
    {
        var data = new SaveData.BankSave()
        {
            countMoney = _countMoney

        };

        return data;
    }


}
