
using UnityEngine;

public interface IUtilityState:IState
{
    public abstract void Behaviour(AIMovingEnemy _aIMovingEnemy,Vector3 _targetPosition);
}
