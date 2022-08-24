using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMany : MonoBehaviour
{
    [SerializeField] private int _indexLevelScene;
    [SerializeField] private int _indexEndlessScene;

    private void SetActivScene(int activSceneIndx)
    {
        SceneManager.LoadScene(activSceneIndx);
    }

    public void ActiveLevelScene()
    {
        SetActivScene(_indexLevelScene);
    }

    public void ActiveEndlessScene()
    {
        SetActivScene(_indexEndlessScene);
    }
}
