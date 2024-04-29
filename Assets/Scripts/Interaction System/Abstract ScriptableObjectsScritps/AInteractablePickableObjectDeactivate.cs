using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInteractablePickableObjectDeactivate : ScriptableObject
{
    public abstract void Deactivate(AInteractablePickableObject _pickableObject);
}
