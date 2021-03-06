using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;

    public Vector3 Direction { get; private set; }
    public int Power { get; private set; }

    internal Bullet Init(Vector3 vector3, int power)
    {
        Direction = vector3;
        Power = power;
        return this;
    }

    void Update()
    {
        _rb.MovePosition((transform.position + (Direction.normalized * Time.deltaTime * _speed)));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<IHealth>()?.TakeDamage(Power);

        Destroy(gameObject);


        var health = collision.GetComponent<IHealth>();
        health.OnDamage += Health_OnDamage;
        health.OnDamage += (arg0) => { };
    }

    private void Health_OnDamage(int arg0)
    {
        throw new NotImplementedException();
    }
}
