using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : Platform
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CollisionHandler>())
        {
            collision.gameObject.GetComponent<CollisionHandler>().EndLevel();
        }
    }
}
