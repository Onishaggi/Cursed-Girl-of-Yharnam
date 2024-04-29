using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/EnemyPresets/AIUtilityEnemyPresets")]
public class AIUtilityEnemyPresets : ScriptableObject
{
    [SerializeField] private TargetInformation _targetInfo;
    [SerializeField] private UtilityStatesPackage _statesPackage;

    public TargetInformation TargetInfo { get { return _targetInfo; } set { _targetInfo = value; } }
    public UtilityStatesPackage statesPackage { get { return _statesPackage; } set { _statesPackage = value; } }
}
