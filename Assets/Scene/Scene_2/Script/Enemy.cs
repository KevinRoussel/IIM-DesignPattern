using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITouchable
{

    [SerializeField] int MaxHealth;

    public int CurrentHealth { get; private set; }

    public void Touch(int power)
    {
        CurrentHealth -= power;
        Debug.Log($"Damage. Current Health : {CurrentHealth}");
    }

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }



}
