using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsSpawner : MonoBehaviour
{
    [SerializeField] private StartPlatform _starPlatform;
    [SerializeField] private FinishPlatform _finishPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private int _maxCountPlatforms;
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


    public void SpawnPlatform(Platform spawnPlatform)
    {
        float platformLenght = spawnPlatform.GetComponent<Renderer>().bounds.size.z;
        Instantiate(spawnPlatform, transform.position + _spawnVector, transform.rotation);

        _spawnVector.z += platformLenght;
    }

    public Platform GetRandomPlatform()
    {
        int randomIndex = Random.Range(0, _platforms.Length);
        return _platforms[randomIndex];
    }

    public Vector3 GetSpawnVector()
    {
        return _spawnVector;
    }
}
