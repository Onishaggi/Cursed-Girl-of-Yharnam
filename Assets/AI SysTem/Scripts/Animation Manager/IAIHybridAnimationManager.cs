using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAIHybridAnimationManager 
{
    public Animator Animator { get; set; }
    public HybridStatesPackageManager HybridStatesPackageManager { get; set; }
}
