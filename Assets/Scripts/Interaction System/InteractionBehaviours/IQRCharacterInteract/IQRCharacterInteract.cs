using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CreateAssetMenu(menuName = "InteractionSystem/QuestObjects/Character Interact Behaviour")]
public class IQRCharacterInteract : AInteractableQuestRelatedObjectInteract
{
    public override void Interact(AInteractableQuestRelatedObject _pickableObject)
    {
        _pickableObject.MFlowchart.ExecuteBlock(_pickableObject.QuestObjectData.BlockName);
        _pickableObject.MFlowchart.SetGameObjectVariable("ActiveInteractableObject", _pickableObject.gameObject);
    }

    
}
