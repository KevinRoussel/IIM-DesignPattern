using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] Transform _spawnPoint;
    [SerializeField] GameObject _bulletPrefab;

    IEnumerator Start()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);

            FireBullet(1);
        }
    }

    void FireBullet(int power)
    {
        var b = Instantiate(_bulletPrefab, _spawnPoint.transform.position, Quaternion.identity, null)
            .GetComponent<Bullet>()
            .Init(_spawnPoint.TransformDirection(Vector3.right), power);
    }

}
