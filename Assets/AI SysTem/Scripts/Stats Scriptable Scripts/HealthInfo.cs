using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Stats/HealthInfo")]
public class HealthInfo : ScriptableObject, IHealthStat
{
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    [SerializeField] private Notifier _healthNotifier;

    public float Health { get { return _health; } }

    public Notifier HealthNotifier { get { return _healthNotifier; } }

    public float MaxHealth {  get { return _maxHealth; } }
}
