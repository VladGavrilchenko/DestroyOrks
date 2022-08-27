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
    private const string _savekey = "BusstSave";


    void Awake()
    {
        Load();
    }


    private void Start()
    {
        UpdateDamageText();
    }

    public void AddPower(int busst)
    {
        _playerDamage += busst;
        Save();
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

    public void SetPlayerDamage(int newPlayerDamage)
    {
        _playerDamage = newPlayerDamage;
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.BusstSave>(_savekey);

        _playerDamage = data.playerDamage;
       
    }

    private void Save()
    {
        SaveManager.Save(_savekey, GetSaveSnapshot());
    }

    private SaveData.BusstSave GetSaveSnapshot()
    {
        var data = new SaveData.BusstSave()
        {
            playerDamage = _playerDamage
        };

        return data;
    }
}
