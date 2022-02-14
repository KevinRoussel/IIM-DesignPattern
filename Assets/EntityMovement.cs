using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    public Vector2 Direction { get; private set; }
    public float Speed { get; private set; }
    public float Angle { get; private set; }


    void Update()
    {
        // Update Movement
        _rb.MovePosition(((Vector2)transform.position + Direction) * Time.deltaTime * Speed);

        // Update Rotation

    }

    public void PrepareDirection(Vector2 v)
    {
        Direction = v.normalized;
    }

    public void PrepareSpeed(float s)
    {
        Speed = s;
    }

    public void PrepareAngle(float angle)
    {

    }




}
