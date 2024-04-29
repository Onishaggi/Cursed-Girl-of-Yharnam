using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InteractionSystem/PickableObjects/Debug Activate Behaviour")]
public class IPODebugActivate : AInteractablePickableObjectActivate
{
    public override void Activate(AInteractablePickableObject _pickableObject)
    {
        //Debug.Log("Activating Character");

        Renderer cubeRenderer = _pickableObject.GetComponent<Renderer>();

        
        if (cubeRenderer.sharedMaterials.Length > 1)
        {
            Debug.Log("Activating Character");
            Material outlineMaterial = cubeRenderer.sharedMaterials[1];
            outlineMaterial.SetFloat("_Scale", 1.1f);
        }
        else
        {
            Debug.LogWarning("No outline material found on the object.");
        }
    }

    
}
