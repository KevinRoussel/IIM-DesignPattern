using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ITouchable
{
    public void Touch(int power)
    {
        Destroy(gameObject);
    }
}
