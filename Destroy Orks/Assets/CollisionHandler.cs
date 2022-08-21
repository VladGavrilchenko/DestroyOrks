using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private float _loadDelayCrash = 1f;
    [SerializeField] private float _loadDelayWin = 1f;

    public void Crash()
    {
        GetComponent<PlayerMove>().enabled= false;
        GetComponentInChildren<Animator>().SetTrigger("Death");
        Invoke("ReloadLevel", _loadDelayCrash);
    }

    public void EndLevel()
    {
        GetComponent<PlayerMove>().enabled = false;
        GetComponentInChildren<Animator>().SetTrigger("Win");
        Invoke("ReloadLevel", _loadDelayWin);
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
