using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdButton : MonoBehaviour
{
    private Button buttonWathAd;

    private void Start()
    {
        buttonWathAd = GetComponent<Button>();
        Bank bank = FindObjectOfType<Bank>();
        buttonWathAd.onClick.AddListener(bank.GetAdsMoneyButton);
    }
}
