
using UnityEngine;

public interface IAggressorState:IState
{
    public abstract void Behaviour(Vector3 _aiPosition,Vector3 _targetPos, IWeapon _aiWeapon);
}
