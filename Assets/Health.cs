using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IHealth
{
    // Champs
    [SerializeField] int _startHealth;
    [SerializeField] int _maxHealth;

    // Propriétés
    public int CurrentHealth { get; private set; }
    public int MaxHealth => _maxHealth;
    public bool IsDead => CurrentHealth <= 0;

    // Events
    public event Action OnSpawn;
    public event Action<int> OnDamage;
    public event Action OnDeath;

    // Methods
    void Awake() => Init();

    void Init()
    {
        CurrentHealth = _startHealth;
        OnSpawn?.Invoke();
    }

    public void TakeDamage(int amount)
    {
        var tmp = CurrentHealth;
        CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
        var delta = CurrentHealth - tmp;
        OnDamage?.Invoke(delta);

        if(CurrentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }

}
