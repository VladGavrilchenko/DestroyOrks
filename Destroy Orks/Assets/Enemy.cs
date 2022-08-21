using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _enemyHitPoint;
    private IPlayerDamage playerDamage;
    private TextMeshPro _textHitPoint;
    private Animator _animator;

    private void Start()
    {
        playerDamage = FindObjectOfType<PlayerBusst>().GetComponent<IPlayerDamage>();
        _animator = GetComponent<Animator>();
        _textHitPoint = GetComponentInChildren<TextMeshPro>();
        UpdateHitPointText();
    }
    
    private void Die()
    {
        _animator.SetTrigger("Death");
        GetComponent<Collider>().enabled = false;
    }

    private void UpdateHitPointText()
    {
        _textHitPoint.text = _enemyHitPoint.ToString();
    }

    public void AddHitPoint(int addHitPoint)
    {
        _enemyHitPoint += addHitPoint;
        UpdateHitPointText();
    }

    public void TakeDamage(int damage)
    {
        _enemyHitPoint -= damage;
        _animator.SetTrigger("TakeDamage");
        if (_enemyHitPoint <=0)
        {
            _enemyHitPoint = 0;
            Die();
        }

        UpdateHitPointText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<CollisionHandler>() != null)
        {
            _animator.SetTrigger("Attack");
            collision.gameObject.GetComponent<CollisionHandler>().Crash();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        TakeDamage(playerDamage.GetPlayerDamage());
    }
}
