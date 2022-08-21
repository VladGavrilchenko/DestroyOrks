using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float controlSpeed;
    [SerializeField] private float xRange;
    private Vector3 target;

    private void Update()
    {
        target = transform.position + transform.forward;
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>())
        {

        }
    }
}
