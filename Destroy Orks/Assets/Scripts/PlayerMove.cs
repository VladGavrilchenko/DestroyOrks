using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _speedToSide = 0.1f;
    private int _sideValue;

    private void Update()
    {
            transform.position += new Vector3(_sideValue * _speedToSide * Time.deltaTime, 0, 0);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    public void movementSide(int newSideValue)
    {
        _sideValue = newSideValue;
    }

}
