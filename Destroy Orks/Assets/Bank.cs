using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCountMoney;
    private int _countMoney;

    private void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        _textCountMoney.text = _countMoney.ToString();
    }

    public void AddMoney(int addMoney)
    {
        _countMoney += addMoney;
        UpdateUI();
    }

    public void GetAdsMoneyButton()
    {
        AdsManager.Instance.ShowAd(this);
    }
}
