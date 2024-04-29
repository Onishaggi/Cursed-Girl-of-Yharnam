using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InteractionSystem/QuestObjects/Debug Interact Behaviour")]
public class IQRDebugInteract : AInteractableQuestRelatedObjectInteract
{
    public override void Interact(AInteractableQuestRelatedObject _pickableObject)
    {
        Debug.Log("Interacting with Character");
    }
}
