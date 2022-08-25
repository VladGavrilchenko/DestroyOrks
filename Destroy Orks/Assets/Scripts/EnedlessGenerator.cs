using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnedlessGenerator : MonoBehaviour
{
    [SerializeField] private StartPlatform _starPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private int _maxCountPlatforms;
    private List<GameObject> activTiles = new List<GameObject>();
    private Vector3 _spawnVector;

    private Transform playerPosition;

    private void Awake()
    {
        

    }
}
