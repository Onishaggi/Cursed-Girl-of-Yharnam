using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="InteractionSystem/PickableObjects/Interactable Behaviours Package")]
public class InteractablePickableObjectBehavioursPackage : ScriptableObject
{
    [Header("---------Activate Behaviours--------")]
    [SerializeField] private List<AInteractablePickableObjectActivate> _activateBehaviours;
    [Header("---------Deactivate Behaviours--------")]
    [SerializeField] private List<AInteractablePickableObjectDeactivate> _deactivateBehaviours;
    [Header("---------Interaction Behaviours--------")]
    [SerializeField] private List<AInteractablePickableObjectInteract> _interactionBehaviours;

    public List<AInteractablePickableObjectActivate> ActivateBehaviours { get { return _activateBehaviours; } set { _activateBehaviours = value; } }
    public List<AInteractablePickableObjectDeactivate> DeactivateBehaviours { get { return _deactivateBehaviours; } set { _deactivateBehaviours = value; } }

    public List<AInteractablePickableObjectInteract> InteractBehaviours { get { return _interactionBehaviours; } set { _interactionBehaviours = value; } }
}
