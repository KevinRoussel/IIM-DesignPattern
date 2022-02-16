using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHealth : MonoBehaviour
{
    [SerializeField] PlayerEntity _player;
    [SerializeField] TextMeshProUGUI _text;

    void UpdateDisplayedHealth(int newValue) => _text.text = newValue.ToString();

    private void Start()
    {
        _player.Health.OnDamage += UpdateDisplayedHealth;

    }

    private void OnDestroy()
    {
        _player.Health.OnDamage -= UpdateDisplayedHealth;
    }

    private void _player_OnHealthChanged(int obj)
    {
        UpdateDisplayedHealth(obj);
    }
}
