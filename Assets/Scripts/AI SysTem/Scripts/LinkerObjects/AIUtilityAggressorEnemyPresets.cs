using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "AI/EnemyPresets/AIUtilityAggressorEnemyPresets")]
public class AIUtilityAggressorEnemyPresets : ScriptableObject
{
    [SerializeField] private TargetInformation _targetInfo;
    [SerializeField] private HybridStatesPackage _statesPackage;
    //[SerializeField] private WeaponInfo _weapon;
    [SerializeField] private MovementStats _movementStats;

    
    public TargetInformation TargetInfo { get { return _targetInfo; } }
    public HybridStatesPackage statesPackage { get { return _statesPackage; } }

    public MovementStats MovementStats { get { return _movementStats; } }

    //public WeaponInfo Weapon { get { return _weapon; } set { _weapon = value; } }
}
