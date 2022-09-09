using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private Canvas _tutorialCanvas;
    // Start is called before the first frame update
    private void Start()
    {
        _tutorialCanvas.enabled = false;
    }

    public void SetEnebledTutorialCanvas(bool isEnebled)
    {
        _tutorialCanvas.enabled = isEnebled;
    }
}
