using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAutoTargeting : MonoBehaviour
{
    [SerializeField] PhysicEvent2D _radius;

    private void Start()
    {
        _radius.TriggerEnter2D += _radius_TriggerEnter2D;
        _radius.TriggerExit2D += _radius_TriggerExit2D; ;


    }

    private void _radius_TriggerEnter2D(Collider2D arg0)
    {
        throw new System.NotImplementedException();
    }

    private void _radius_TriggerExit2D(Collider2D arg0)
    {
        throw new System.NotImplementedException();
    }
}
