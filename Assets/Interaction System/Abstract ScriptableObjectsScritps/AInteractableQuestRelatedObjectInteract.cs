using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInteractableQuestRelatedObjectInteract : ScriptableObject
{
    public abstract void Interact(AInteractableQuestRelatedObject _pickableObject);
}
