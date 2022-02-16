using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth 
{
    int CurrentHealth { get; }
    int MaxHealth { get; }
    bool IsDead { get; }

    event Action OnSpawn;
    event Action<int> OnDamage;
    event Action OnDeath;

    void TakeDamage(int amount);

}
