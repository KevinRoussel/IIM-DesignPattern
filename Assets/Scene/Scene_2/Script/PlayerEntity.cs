using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour, ITouchable
{
    [SerializeField] int MaxHealth;

    public event Action<int> OnHealthChanged;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void Touch(int power)
    {
        CurrentHealth -= power;
        OnHealthChanged?.Invoke(CurrentHealth);
        Debug.Log($"Damage. Current Health : {CurrentHealth}");
    }
}


