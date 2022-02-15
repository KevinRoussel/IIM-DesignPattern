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
        _player.OnHealthChanged += UpdateDisplayedHealth;

    }

    private void OnDestroy()
    {
        _player.OnHealthChanged -= UpdateDisplayedHealth;
    }

    private void _player_OnHealthChanged(int obj)
    {
        UpdateDisplayedHealth(obj);
    }
}
