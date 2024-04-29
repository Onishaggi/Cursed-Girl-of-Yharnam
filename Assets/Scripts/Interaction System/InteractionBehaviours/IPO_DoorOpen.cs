using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InteractionSystem/PickableObjects/Door Interact Behaviour")]
public class IPO_DoorOpen : AInteractablePickableObjectInteract
{
    public override void Interact(AInteractablePickableObject _pickableObject)
    {
        if (_pickableObject.transform.rotation.y == 0)
        {
            _pickableObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        else
        {
            _pickableObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        Debug.Log("Interacting");
    }
}
