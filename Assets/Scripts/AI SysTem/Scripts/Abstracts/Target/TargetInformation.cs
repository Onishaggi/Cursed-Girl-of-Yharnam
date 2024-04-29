using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Target/TargetInformation")]
public class TargetInformation : ScriptableObject, ITargetInfo
{
    [SerializeField] string _targetTag;
    public string Tag { get { return _targetTag; }}
}
