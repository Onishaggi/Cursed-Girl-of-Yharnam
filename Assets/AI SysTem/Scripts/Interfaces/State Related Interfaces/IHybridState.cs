
using UnityEngine;

public interface IHybridState:IState
{
    public abstract void Behaviour(IAIMovingAggressorEnemy _aiEnemy,Transform _currentTransform);
}
