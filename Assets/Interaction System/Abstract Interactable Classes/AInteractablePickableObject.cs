using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class AInteractablePickableObject : MonoBehaviour
{

    abstract public InteractablePickableObjectData ItemData {  get; set; }

    abstract public InteractablePickableObjectBehavioursPackage InteractablePickableObjectBehaviourPackage { get; set; }
    //abstract public string InteractableName { get;  set;  }
    //abstract public string InteractableDescription { get; set; }
    //abstract public bool CanInteract { get; set; }
    //abstract public Flowchart ObjectFlowChart { get; set; }
    //abstract public int ItemCount { get; set; }
    //######################################################################
    abstract public UnityAction ItemTakenListener { get; set; }
    abstract public UnityAction ItemNotTakenListener { get; set; }

    //abstract public void Activate();

    //abstract public void Deactivate();

    //abstract public void Interact();

    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
