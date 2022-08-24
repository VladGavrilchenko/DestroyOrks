using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

interface IPlayerDamage
{
    int GetPlayerDamage();
}

public class PlayerBusst : MonoBehaviour , IPlayerDamage
{
    [SerializeField] private int _playerDamage;
    [SerializeField] TextMeshProUGUI _damageText;

    void Awake()
    {
        int numGameSessions = FindObjectsOfType<PlayerBusst>().Length;
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    private void Start()
    {
        UpdateDamageText();
    }

    public void AddPower(int busst)
    {
        _playerDamage += busst;
        UpdateDamageText();
    }

    private void UpdateDamageText()
    {
        _damageText.text = _playerDamage.ToString();
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
        return _playerDamage;
    }
}
