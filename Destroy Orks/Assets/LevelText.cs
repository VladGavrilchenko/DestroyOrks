using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelText : MonoBehaviour
{
    private TextMeshProUGUI _leveText;

    private void Start()
    {
        _leveText = GetComponentInChildren<TextMeshProUGUI>();
        GameProgres gameProgres = FindObjectOfType<GameProgres>();
        _leveText.text = "Level " + gameProgres.GetLevelCount().ToString();
    }
}
