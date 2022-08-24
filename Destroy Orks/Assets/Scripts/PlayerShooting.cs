using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    [SerializeField] private float _distanceToShooting;
    private ParticleSystem _shootParticle;

    private void Start()
    {
        _shootParticle = GetComponentInChildren<ParticleSystem>();
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, _distanceToShooting, _layer))
        {
            _shootParticle.enableEmission = true;
        }
        else
        {
            _shootParticle.enableEmission = false;
        }
    }

    private void OnDisable()
    {
        _shootParticle.Stop();
    }
}
