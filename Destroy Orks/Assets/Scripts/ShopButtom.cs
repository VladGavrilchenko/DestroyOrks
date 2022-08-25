using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopButtom : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _costText;
    private ShopPower _shopPower;
    private Button _buttonShop;

    private void Start()
    {
        _buttonShop = GetComponent<Button>();
        _shopPower = FindObjectOfType<ShopPower>();
        _buttonShop.onClick.AddListener(_shopPower.BuyBusst);
        _shopPower.NewCostEvent.AddListener(UpdateCostText);
        UpdateCostText();
    }

    private void UpdateCostText()
    {
        _costText.text = _shopPower.GetCost().ToString();
    }
}
