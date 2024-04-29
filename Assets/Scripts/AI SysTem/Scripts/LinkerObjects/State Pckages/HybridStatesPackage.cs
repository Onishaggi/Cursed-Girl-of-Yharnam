using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Packages/HybridStatesPackage")]
public class HybridStatesPackage : ScriptableObject,IHybridStatesHandler
{
    [Header("*************State Behaviours****************")]
    //unity deosnt serialize interfaces
    [SerializeField] private List<HybridState> _states;
    //[SerializeReference]public List<IHybridState> _states;
    [Header("***********State Activations*****************")]
    [Tooltip("This List Size Should be States List Size -1./nBecause this list Defines the Distance required to go to the NEXT State.")]
    [SerializeField] private List<float> _activationDistance;

    public List<HybridState> States { get { return _states; } set { _states = value; } }
    public List<float> ActivationDistance { get { return _activationDistance; } set { _activationDistance = value; } }
}
