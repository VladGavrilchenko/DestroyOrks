using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsSpawner : MonoBehaviour
{
    [SerializeField] private StartPlatform _starPlatform;
    [SerializeField] private FinishPlatform _finishPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private int _maxCountPlatforms;
    [SerializeField] private int _enemyBusst;
    private Vector3 _spawnVector;

    private void Start()
    {
        GeneretLevel();
    }

    private void GeneretLevel()
    {
        _spawnVector = transform.position;

        SpawnPlatform(_starPlatform);
        for (int i = 0; i < _maxCountPlatforms; i++)
        {
            SpawnPlatform(GetRandomPlatform());
        }
        SpawnPlatform(_finishPlatform);
    }


    private void SpawnPlatform(Platform spawnPlatform)
    {
        float platformLenght = spawnPlatform.GetComponent<Renderer>().bounds.size.z;
        Instantiate(spawnPlatform, transform.position + _spawnVector, transform.rotation);

        if (spawnPlatform.hasEnenie() == true)
        {
            spawnPlatform.AddToEnemiesPower(_enemyBusst);
        }

        _spawnVector.z += platformLenght;
        _enemyBusst++;
    }

    private Platform GetRandomPlatform()
    {
        int randomIndex = Random.Range(0, _platforms.Length);
        return _platforms[randomIndex];
    }
}
