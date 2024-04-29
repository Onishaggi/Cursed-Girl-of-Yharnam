using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class AInteractablePickableObjectActivate : ScriptableObject
{
    public abstract void Activate(AInteractablePickableObject _pickableObject);
}
