using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsSpawner : MonoBehaviour
{
    [SerializeField] private Platform _starPlatform;
    [SerializeField] private FinishPlatform _finishPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private int maxCountPlatforms;
    [SerializeField] private int enemyBusst;
    private Vector3 _spawnVector;

    private void Start()
    {
        GeneretLevel();
    }

    private void GeneretLevel()
    {
        SpawnPlatform(_starPlatform);
        _spawnVector = transform.position;
        for (int i = 0; i < maxCountPlatforms; i++)
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
            spawnPlatform.AddToEnemiesPower(enemyBusst);
        }

        _spawnVector.z += platformLenght;
        enemyBusst++;
    }
    


    private Platform GetRandomPlatform()
    {
        int randomIndex = Random.Range(0, _platforms.Length);
        return _platforms[randomIndex];
    }
}
