using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public static class AIMovementBehaviours
{

    public static Vector3 seeking(Vector3 _userTransformPos,Vector3 _targetPos)
    {
        Vector3 _directionToPlayer = Vector3.Normalize(_targetPos - _userTransformPos);

        return _directionToPlayer;

    }

    public static Quaternion LookAtTarget(Vector3 _targetDirection)
    {
        Quaternion _targetRotation = Quaternion.LookRotation(_targetDirection);

        return _targetRotation;
    }

}
