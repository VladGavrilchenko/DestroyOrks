using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysMeshMaterial : MonoBehaviour
{
    [SerializeField] private Texture[] meshes;

    public Texture GetRandomMesh()
    {
        int randomIndex = Random.Range(0, meshes.Length);

        return meshes[randomIndex];
    }
}
