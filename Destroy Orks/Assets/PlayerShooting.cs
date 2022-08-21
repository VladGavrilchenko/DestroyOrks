using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] private float _distanceToShooting;
    private ParticleSystem particle;
    private void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, _distanceToShooting, layer))
        {
            particle.gameObject.SetActive(true);
        }
        else
        {
            particle.gameObject.SetActive(false);
        }
    }
}
