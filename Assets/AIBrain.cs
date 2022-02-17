using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    [SerializeField] EntityRotation _currentRotation;
    [SerializeField] EntityFire _fire;

    [SerializeField] PlayerEntity _playerTarget;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 5f));

            _fire.FireBullet(2);
        }
    }

    private void Update()
    {
        _currentRotation.AimPosition = _playerTarget.transform.position;
    }

}


