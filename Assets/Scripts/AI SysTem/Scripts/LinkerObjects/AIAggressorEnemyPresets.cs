using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/EnemyPresets/AIAggressorEnemyPresets")]
public class AIAggressorEnemyPresets : ScriptableObject
{
    [SerializeField] private TargetInformation _targetInfo;
    [SerializeField] private AggressorStatesPackage _statesPackage;

    public TargetInformation TargetInfo { get { return _targetInfo; } }
    public AggressorStatesPackage statesPackage { get { return _statesPackage; } }
}
