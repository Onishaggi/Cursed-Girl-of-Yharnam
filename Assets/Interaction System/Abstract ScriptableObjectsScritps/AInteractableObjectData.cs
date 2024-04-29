using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInteractableObjectData : ScriptableObject
{
    abstract public string InteractableName { get; set; }

    abstract public string BlockName { get; set; }
    abstract public string InteractableDescription { get; set; }
    abstract public bool CanInteract { get; set; }
    abstract public Flowchart ObjectFlowChart{ get; set; }
}
