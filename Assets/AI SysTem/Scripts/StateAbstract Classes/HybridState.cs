using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HybridState :ScriptableObject, IHybridState
{
    public abstract string StateName { get; set; }
    public abstract bool IsStateActive { get; set; }
    public abstract float StopingDistance { get; set; }

    public abstract void Behaviour(IAIMovingAggressorEnemy _aiEnemy, Transform _currentTransform);
    

    
}
