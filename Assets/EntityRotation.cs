using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EntityRotation : MonoBehaviour
{
    [SerializeField] Camera _camera;

    public Vector2 AimPosition { get; set; }

    static Quaternion AimPositionToZRotation(Vector3 entityPosition, Vector3 aimPosition, Camera c)
    {
        Vector3 diff = (aimPosition - entityPosition).normalized;
        return Quaternion.Euler(0f, 0f, Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg);
    }

    private void Update()
    {
        transform.rotation = AimPositionToZRotation(transform.position, AimPosition, _camera);
    }

}
