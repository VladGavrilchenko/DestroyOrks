using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgres : MonoBehaviour
{
    [SerializeField] private int _addHitPointEnemy;
    private int _levelCount;


    private const string savekey = "MainSave";

    private void Awake()
    {
        Load();
    }

    public int GetAddHitPointEnemy()
    {
        return _addHitPointEnemy;
    }

    public int GetLevelCount()
    {
        return _levelCount;
    }

    public void AddCountLevel()
    {
        _addHitPointEnemy++;
        _levelCount++;
        Save();
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.PlayerProfil>(savekey);

        _addHitPointEnemy = data.addHitPointEnemy;
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

            addHitPointEnemy = _addHitPointEnemy,
            levelCount = _levelCount,

        };

        return data;
    }
}
