using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EntityRotation : MonoBehaviour
{
    [SerializeField] CameraReference _camera;

    public Vector2 AimPosition { get; set; }

    public static Quaternion AimPositionToZRotation(Vector3 entityPosition, Vector3 aimPosition, Camera c)
    {
        Vector3 diff = (aimPosition - entityPosition).normalized;
        return Quaternion.Euler(0f, 0f, Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg);
    }

    public void ForceAim(Vector3 aimPosition) => AimPosition = aimPosition;

    private void LateUpdate()
    {
        transform.rotation = AimPositionToZRotation(transform.position, AimPosition, _camera.Instance);
    }

}
