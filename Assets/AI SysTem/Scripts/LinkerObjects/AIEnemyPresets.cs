using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIEnemyPresets : ScriptableObject
{
    [SerializeField] private TargetInformation _targetInfo;
    [SerializeField] private StatesPackage _statesPackage;

    public TargetInformation TargetInfo {  get { return _targetInfo; } set { _targetInfo = value; } }
    public StatesPackage statesPackage { get { return _statesPackage; } set { _statesPackage = value; } }



}
