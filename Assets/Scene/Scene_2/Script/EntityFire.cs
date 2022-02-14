using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFire : MonoBehaviour
{
    [SerializeField] Transform _spawnPoint;
    [SerializeField] Bullet _bulletPrefab;

    public void FireBullet(int power)
    {
        var b = Instantiate(_bulletPrefab, _spawnPoint.transform.position, Quaternion.identity, null)
            .Init(_spawnPoint.TransformDirection(Vector3.right), power);
    }

}
