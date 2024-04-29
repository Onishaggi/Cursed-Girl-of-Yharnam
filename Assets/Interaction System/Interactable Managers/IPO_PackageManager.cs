using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPO_PackageManager
{
    private InteractablePickableObjectBehavioursPackage _interactablePickableObjectBehaviourPackage;

    AInteractablePickableObject _pickableObject;

    public IPO_PackageManager(AInteractablePickableObject _pickableObject)
    {
        this._pickableObject = _pickableObject;
        _interactablePickableObjectBehaviourPackage = _pickableObject.InteractablePickableObjectBehaviourPackage;
    }

    public void InteractBehaviours()
    {
        foreach(var interaction in _interactablePickableObjectBehaviourPackage.InteractBehaviours)
        {
            interaction.Interact(_pickableObject);
        }
    }
    public void ActivateBehaviours()
    {
        foreach (var interaction in _interactablePickableObjectBehaviourPackage.ActivateBehaviours)
        {
            interaction.Activate(_pickableObject);
        }
    }
    public void DeactivateBehaviours()
    {
        foreach (var interaction in _interactablePickableObjectBehaviourPackage.DeactivateBehaviours)
        {
            interaction.Deactivate(_pickableObject);
        }
    }

}
