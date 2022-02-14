using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed=1;

    public Vector2 Direction { get; private set; }


    void Update()
    {
        // Update Movement
        _rb.MovePosition(((Vector2)transform.position + Direction) * Time.deltaTime*_speed);

    }

    public void PrepareDirection(Vector2 v)
    {
        Direction = v.normalized;
    }

}
