using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="AI/Packages/AggressorStatesPackage")]
public class AggressorStatesPackage : ScriptableObject,IAggressorStateHandler
{
    [Header("*************State Behaviours****************")]
    [SerializeField] private List<IAggressorState> _states;
    [Header("***********State Activations*****************")]
    [Tooltip("This List Size Should be States List Size -1./nBecause this list Defines the Distance required to go to the NEXT State.")]
    [SerializeField] private List<float> _activationDistance;

    public List<IAggressorState> States { get { return _states; } set { _states = value; } }
    public List<float> ActivationDistance { get { return _activationDistance; } set { _activationDistance = value; } }
}
