using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private int _indexMainScene;
    [SerializeField] private float _loadDelayCrash = 1f;
    [SerializeField] private float _loadDelayWin = 1f;

    public void Crash()
    {
        GetComponent<PlayerMove>().enabled= false;
        GetComponent<PlayerShooting>().enabled= false;
        GetComponentInChildren<Animator>().SetTrigger("Death");
        Invoke("LoadMainScene", _loadDelayCrash);
    }

    public void EndLevel()
    {
        GetComponent<PlayerMove>().enabled = false;
        GetComponent<PlayerShooting>().enabled = false;
        GetComponentInChildren<Animator>().SetTrigger("Win");
        Invoke("LoadMainScene", _loadDelayWin);
    }

    private void LoadMainScene()
    {
        SceneManager.LoadScene(_indexMainScene);
    }
}
