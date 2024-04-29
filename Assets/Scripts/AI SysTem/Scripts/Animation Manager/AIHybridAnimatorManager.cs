using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHybridAnimatorManager : IAIHybridAnimationManager,IListener
{
    private Animator _animator;

    private HybridStatesPackageManager _statePackageManager;

    private List<HybridState> _statesPackage;
    public Animator Animator { get { return _animator; } set { _animator = value; } }
    public HybridStatesPackageManager HybridStatesPackageManager { get { return _statePackageManager; } set { _statePackageManager = value; } }

    public AIHybridAnimatorManager(Animator animator,HybridStatesPackageManager hybridStatesPackageManager) 
    {
    
        this._animator = animator;
        this._statePackageManager = hybridStatesPackageManager;
        _statesPackage = hybridStatesPackageManager.States;
        hybridStatesPackageManager.StateChangeNotify.AddListener(this);
    
    }

    public void SetAnimatorParams()
    {
        foreach (HybridState state in _statesPackage)
        {
            Animator.SetBool(state.StateName, state.IsStateActive);
        }

    }

    public void OnNotify()
    {
        SetAnimatorParams();
    }
}
