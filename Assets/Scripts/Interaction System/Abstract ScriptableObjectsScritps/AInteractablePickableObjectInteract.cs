using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInteractablePickableObjectInteract : ScriptableObject
{
    public abstract void Interact(AInteractablePickableObject _pickableObject);
}
