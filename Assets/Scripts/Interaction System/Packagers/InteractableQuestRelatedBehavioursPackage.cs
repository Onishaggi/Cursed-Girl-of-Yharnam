using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InteractionSystem/QuestObjects/ Quest Behaviour Package")]
public class InteractableQuestRelatedBehavioursPackage : ScriptableObject
{
    [Header("---------Activate Behaviours--------")]
    [SerializeField] private List<AInteractableQuestRelatedObjectActivate> _activateBehaviours;
    [Header("---------Deactivate Behaviours--------")]
    [SerializeField] private List<AInteractableQuestRelatedObjectDeactivate> _deactivateBehaviours;
    [Header("---------Interaction Behaviours--------")]
    [SerializeField] private List<AInteractableQuestRelatedObjectInteract> _interactionBehaviours;

    public List<AInteractableQuestRelatedObjectActivate> ActivateBehaviours { get { return _activateBehaviours; } set { _activateBehaviours = value; } }
    public List<AInteractableQuestRelatedObjectDeactivate> DeactivateBehaviours { get { return _deactivateBehaviours; } set { _deactivateBehaviours = value; } }
    public List<AInteractableQuestRelatedObjectInteract> InteractBehaviours { get { return _interactionBehaviours; } set { _interactionBehaviours = value; } }
}
