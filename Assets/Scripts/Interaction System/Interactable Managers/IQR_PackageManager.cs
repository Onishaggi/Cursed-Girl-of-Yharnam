using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IQR_PackageManager
{
    private InteractableQuestRelatedBehavioursPackage _interactableQuestRelatedBehaviourPackage;

    AInteractableQuestRelatedObject _questObject;

    public IQR_PackageManager(AInteractableQuestRelatedObject _questObject)
    {
        this._questObject = _questObject;
        _interactableQuestRelatedBehaviourPackage = _questObject.InteractableQuestRelatedBehaviourPackage;
    }

    public void InteractBehaviours()
    {
        foreach (var interaction in _interactableQuestRelatedBehaviourPackage.InteractBehaviours)
        {
            interaction.Interact(_questObject);
        }
    }
    public void ActivateBehaviours()
    {
        foreach (var interaction in _interactableQuestRelatedBehaviourPackage.ActivateBehaviours)
        {
            interaction.Activate(_questObject);
        }
    }
    public void DeactivateBehaviours()
    {
        foreach (var interaction in _interactableQuestRelatedBehaviourPackage.DeactivateBehaviours)
        {
            interaction.Deactivate(_questObject);
        }
    }
}
