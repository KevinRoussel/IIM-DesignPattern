using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    [SerializeField] EntityRotation _currentRotation;

    [SerializeField] PlayerEntity _playerTarget;

    private void Update()
    {
        _currentRotation.AimPosition = _playerTarget.transform.position;
    }

}
