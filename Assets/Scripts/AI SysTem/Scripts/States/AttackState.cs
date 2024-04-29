using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/States/AttackingSate")]
public class AttackState : HybridState
{
    [SerializeField] private string _stateName;
    [SerializeField] private float _stopingDistance = 0;
    [SerializeField] private Vector3 _weaponPosOffest = Vector3.zero;
    private bool _isStateActive = false;
    
    public override float StopingDistance { get { return _stopingDistance; } set { StopingDistance = value; } }

    public override string StateName { get { return _stateName; } set { _stateName = value; } }
    public override bool IsStateActive { get { return _isStateActive; } set { _isStateActive = value; } }

    public override void Behaviour(IAIMovingAggressorEnemy _aiEnemy, Transform _currentTransform)
    {
        
            Vector3 dir = (_aiEnemy.TargetGO.transform.position - _currentTransform.position).normalized;
            Quaternion angleToFaceTarget = AIMovementBehaviours.LookAtTarget(dir);

            angleToFaceTarget.x = _currentTransform.transform.rotation.x;
            angleToFaceTarget.z = _currentTransform.transform.rotation.z;
            _currentTransform.rotation = Quaternion.Lerp(_currentTransform.rotation, angleToFaceTarget, Time.deltaTime * _aiEnemy.RotationSpeed);
            _aiEnemy.Weapon.TriggerFire(_weaponPosOffest);
            Debug.Log("Attacking"); 
        

    }


    //public AIEnemy AIManager { get { return _aiManager; } set { _aiManager = value; } }



    //public void Behaviour(Vector3 _aiPosition, Vector3 _targetPosition, Rigidbody _aiRigidBody, IWeapon _aiWeapon)
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void Behaviour(AIMovingDamageDealerEnemy _aiManager)
    //{
    //    Debug.Log("attacling");
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
