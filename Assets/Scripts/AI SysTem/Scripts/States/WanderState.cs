using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName ="AI/States/WanderingSate")]
public class WanderState : HybridState
{
    [SerializeField] List<Vector3> _wayPoints;
    [SerializeField] private float _stopingDistance=0;
    [SerializeField] private string _stateName;
    private bool _isStateActive=false;

    public override float StopingDistance { get { return _stopingDistance; } set { StopingDistance = value; } }

    public override string StateName { get { return _stateName; } set { _stateName = value; } }
    public override bool IsStateActive { get { return _isStateActive; } set { _isStateActive = value; } }

    int tempcouner=0;

    public override void Behaviour(IAIMovingAggressorEnemy _aiEnemy, Transform _currentTransform)
    {
        if (Vector3.SqrMagnitude(_wayPoints[tempcouner] - _currentTransform.position) <= _stopingDistance * _stopingDistance)
        {
            tempcouner++;
            if (tempcouner == _wayPoints.Count)
            {
                tempcouner = 0;
            }
        }
        Vector3 _directionToTarget = AIMovementBehaviours.seeking(_currentTransform.position, _wayPoints[tempcouner]);
        Quaternion angleToFaceTarget = AIMovementBehaviours.LookAtTarget(_directionToTarget);

        if (_aiEnemy.EnemyRB != null)
        {
            _aiEnemy.EnemyRB.velocity = _directionToTarget * _aiEnemy.MovementSpeed;

        }
        angleToFaceTarget.x = _currentTransform.transform.rotation.x;
        angleToFaceTarget.z = _currentTransform.transform.rotation.z;

        _currentTransform.rotation = Quaternion.Lerp(_currentTransform.rotation, angleToFaceTarget, Time.deltaTime * _aiEnemy.RotationSpeed);

    }


    //public void Behaviour(Transform _aiTransform, Rigidbody _aiRigidBody, IWeapon _aiWeapon)
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void Behaviour(Vector3 _aiPosition, Vector3 _targetPosition, Rigidbody _aiRigidBody, IWeapon _aiWeapon)
    //{
    //    if (Vector3.SqrMagnitude(_wayPoints[tempcouner] - _aiPosition) <= _stopingDistance * _stopingDistance)
    //    {
    //        tempcouner++;
    //        if (tempcouner == _wayPoints.Count)
    //        {
    //            tempcouner = 0;
    //        }
    //    }
    //    Vector3 _directionToTarget = AIMovementBehaviours.seeking(_aiPosition, _wayPoints[tempcouner]);
    //    Quaternion angleToFaceTarget = AIMovementBehaviours.LookAtTarget(_directionToTarget);

    //    if (_aiRigidBody != null)
    //    {
    //        _aiRigidBody.velocity= _directionToTarget * 

    //    }
    //}

    //public void Behaviour(AIMovingDamageDealerEnemy _aiManager)
    //{
    //    if (Vector3.SqrMagnitude(_wayPoints[tempcouner] - _aiManager.transform.position) <= _stopingDistance*_stopingDistance)
    //    {
    //        tempcouner++;
    //        if (tempcouner == _wayPoints.Count)
    //        {
    //            tempcouner = 0;
    //        }
    //    }
    //    Vector3 _directionToTarget=AIMovementBehaviours.seeking(_aiManager.transform.position, _wayPoints[tempcouner]);
    //    Quaternion angleToFaceTarget= AIMovementBehaviours.LookAtTarget(_directionToTarget);
    //    Rigidbody _aiManagerRB= _aiManager.GetComponent<Rigidbody>();
    //    if(_aiManagerRB != null )
    //    {

    //    }
    //}


    //public AIEnemy AIManager { get { return _aiManager; } set { _aiManager = value; } }
}
