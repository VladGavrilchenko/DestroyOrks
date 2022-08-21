using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : Platform
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMove>())
        {

        }
    }
}
