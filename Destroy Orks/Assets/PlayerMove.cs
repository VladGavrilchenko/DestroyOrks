using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedToSide = 0.1f;
    private bool _isAlive;
    private int sideValue;

    private void Start()
    {   
        _isAlive = true;
    }

    private void Update()
    {
        if (_isAlive)
        {
            transform.position += new Vector3(sideValue * speedToSide * Time.deltaTime, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }

    public void movementSide(int newSideValue)
    {
        sideValue = newSideValue;
    }

}
