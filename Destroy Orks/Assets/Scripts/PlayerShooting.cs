using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    [SerializeField] private float _distanceToShooting;
    private AudioSource _audioSource;
    private ParticleSystem _shootParticle;

    private void Start()
    {
        _audioSource= GetComponentInChildren<AudioSource>();
        _shootParticle = GetComponentInChildren<ParticleSystem>();
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, _distanceToShooting, _layer))
        {
            _shootParticle.enableEmission = true;

            if (_audioSource.isPlaying == false)
            {
                _audioSource.Play();
            }
           
        }
        else
        {
            _shootParticle.enableEmission = false;
            _audioSource.Stop();
        }
    }

    private void OnDisable()
    {
        _shootParticle.Stop();
    }
}
