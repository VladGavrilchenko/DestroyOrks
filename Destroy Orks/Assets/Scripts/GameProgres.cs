using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgres : MonoBehaviour
{
    [SerializeField] private int _multiplyHitPointEnemy;
    private int _levelCount;


    private const string savekey = "MainSave";

    private void Awake()
    {
        Load();
    }

    public int GetMultiplyHitPointEnemy()
    {
        return _multiplyHitPointEnemy;
    }

    public int GetLevelCount()
    {
        return _levelCount;
    }

    public void AddCountLevel()
    {
        _multiplyHitPointEnemy++;
        _levelCount++;
        Save();
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.PlayerProfil>(savekey);

        _multiplyHitPointEnemy = data.multiplyHitPointEnemy;
        _levelCount = data.levelCount;
    }

    private void Save()
    {
        SaveManager.Save(savekey, GetSaveSnapshot());
    }

    private SaveData.PlayerProfil GetSaveSnapshot()
    {
        var data = new SaveData.PlayerProfil()
        {

            multiplyHitPointEnemy = _multiplyHitPointEnemy,
            levelCount = _levelCount,

        };

        return data;
    }
}
