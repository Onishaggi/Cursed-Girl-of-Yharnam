using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InteractionSystem/PickableObjects/Debug Interact Behaviour")]
public class IPODebugInteraction : AInteractablePickableObjectInteract
{
    public override void Interact(AInteractablePickableObject _pickableObject)
    {
        Debug.Log("Interacting");
    }

    
}
