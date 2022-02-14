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
            yield return new WaitForSeconds(1f);

            _fire.FireBullet(1);
        }
    }

    private void Update()
    {
        // Je veux targeter constamment le joueur

    }

}


