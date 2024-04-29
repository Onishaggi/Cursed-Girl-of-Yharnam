using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovingEnemy : MonoBehaviour,IAIMovingEnemy
{
    public Rigidbody EnemyRB { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public UtilityStatesPackageManager StatesPackageManager { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public float MovementSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public float RotationSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public TargetInformation TargetInfo => throw new System.NotImplementedException();

    public GameObject TargetGO { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
