using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _enemyHitPoint;
    [SerializeField] private int _coutnAddMoney;
    private IPlayerDamage _iPlayerDamage;
    private TextMeshPro _textHitPoint;
    private Animator _animator;


    private void OnEnable()
    {
        MultiplyHitPoint(FindObjectOfType<GameProgres>().GetMultiplyHitPointEnemy());
        _iPlayerDamage = FindObjectOfType<PlayerBusst>().GetComponent<IPlayerDamage>();
        _animator = GetComponent<Animator>();
        _textHitPoint = GetComponentInChildren<TextMeshPro>();
        UpdateHitPointText();
    }

    private void Die()
    {
        _animator.SetTrigger("Death");
        _textHitPoint.enabled = false;
        GetComponent<Collider>().enabled = false;
        FindObjectOfType<Bank>().AddMoney(_coutnAddMoney);
    }

    private void UpdateHitPointText()
    {
        _textHitPoint.text = _enemyHitPoint.ToString();
    }

    public void MultiplyHitPoint(int addHitPoint)
    {
        _enemyHitPoint *= addHitPoint;
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
        TakeDamage(_iPlayerDamage.GetPlayerDamage());
    }
}
