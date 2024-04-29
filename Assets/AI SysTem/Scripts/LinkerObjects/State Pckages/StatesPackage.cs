using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatesPackage : ScriptableObject,IStatesHandler
{
    [Header("*************State Behaviours****************")]
    [SerializeField] private List<IState> _states;
    [Header("***********State Activations*****************")]
    [Tooltip("This List Size Should be States List Size -1./nBecause this list Defines the Distance required to go to the NEXT State.")]
    [SerializeField] private List<float> _activationDistance;

    public List<IState> States { get { return _states; } set { _states = value; } }
    public List<float> ActivationDistance { get { return _activationDistance; } set {  _activationDistance=value; } }
    

    
}
