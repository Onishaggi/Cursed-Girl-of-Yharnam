using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealthStat
{
    public Notifier HealthNotifier { get; }
    public float Health { get; }
    public float MaxHealth { get; }
}
