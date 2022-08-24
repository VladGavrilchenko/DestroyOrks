using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtom : MonoBehaviour
{
    private Button buttonShop;

    private void Start()
    {
        buttonShop = GetComponent<Button>();
        ShopPower shopPower = FindObjectOfType<ShopPower>();
        buttonShop.onClick.AddListener(shopPower.BuyBusst);
    }
}
