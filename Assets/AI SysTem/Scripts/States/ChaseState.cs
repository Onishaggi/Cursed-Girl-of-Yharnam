using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/States/ChasingSate")]
public class ChaseState : HybridState
{
    [SerializeField] private string _stateName;
    [SerializeField] private float _stopingDistance = 0;
    private bool _isStateActive = false;
    public override float StopingDistance { get { return _stopingDistance; } set { StopingDistance = value; } }

    public override string StateName { get { return _stateName; } set { _stateName = value; } }
    public override bool IsStateActive { get { return _isStateActive; } set { _isStateActive = value; } }

    public override void Behaviour(IAIMovingAggressorEnemy _aiEnemy, Transform _currentTransform)
    {
        Vector3 _directionToTarget = AIMovementBehaviours.seeking(_currentTransform.position,_aiEnemy.TargetGO.transform.position);
        Quaternion angleToFaceTarget = AIMovementBehaviours.LookAtTarget(_directionToTarget);

        if (_aiEnemy.EnemyRB != null)
        {
            _aiEnemy.EnemyRB.velocity = _directionToTarget * _aiEnemy.MovementSpeed;

        }
        angleToFaceTarget.x = _currentTransform.transform.rotation.x;
        angleToFaceTarget.z = _currentTransform.transform.rotation.z;
        _currentTransform.rotation = Quaternion.Lerp(_currentTransform.rotation, angleToFaceTarget, Time.deltaTime * _aiEnemy.RotationSpeed);
    }

    //public AIEnemy AIManager { get  { return _aiManager; } set { _aiManager = value; } }


    //public void Behaviour(Vector3 _aiPosition,Vector3 _targetPosition , Rigidbody _aiRigidBody, IWeapon _aiWeapon)
    //{
    //    throw new System.NotImplementedException();
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
