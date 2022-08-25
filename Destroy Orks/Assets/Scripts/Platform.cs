using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnEnable()
    {
        Enemy[] enemies = GetComponentsInChildren<Enemy>();

        if(enemies.Length != 0)
        {
            foreach(Enemy enemy in enemies)
            {
                enemy.enabled = true;
            }
        }

    }


}
