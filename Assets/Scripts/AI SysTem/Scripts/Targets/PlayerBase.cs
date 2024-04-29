using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour,IHealthStat
{
    [SerializeField] HealthInfo _healthInfo;

    private float _health;
    private float _maxHealth;

    public Notifier HealthNotifier { get {return _healthInfo.HealthNotifier; } }

    public float Health { get { return _health; } set { _health = value; } }

    public float MaxHealth {  get { return _maxHealth; } set { _maxHealth = value; } }
    // Start is called before the first frame update
    void Start()
    {
        _health = _healthInfo.Health;
        _maxHealth = _healthInfo.MaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamaged(int _damageValue)
    {
        Health-=_damageValue;

        HealthNotifier.Notify();
    }
}
