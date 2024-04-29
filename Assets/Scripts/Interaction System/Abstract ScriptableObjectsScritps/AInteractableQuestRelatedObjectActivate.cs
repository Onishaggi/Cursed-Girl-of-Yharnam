using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInteractableQuestRelatedObjectActivate : ScriptableObject
{
    public abstract void Activate(AInteractableQuestRelatedObject _pickableObject);
}
