using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAggressorEnemy : IAIAggressorEnemy
{
    public IWeapon Weapon { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public TargetInformation TargetInfo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public AIEnemyPresets AIEnemyPresets { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public GameObject TargetGO { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public StatesPackageManager StatesPackageManager { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    AggressorStatesPackageManager IAIAggressorEnemy.StatesPackageManager { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
