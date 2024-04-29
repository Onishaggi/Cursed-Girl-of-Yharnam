using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class AInteractableQuestRelatedObject : MonoBehaviour
{
    abstract public InteractableQuestRelatedData QuestObjectData { get; set; }

    abstract public Flowchart MFlowchart { get; set; }
    abstract public InteractableQuestRelatedBehavioursPackage InteractableQuestRelatedBehaviourPackage { get; set; }
    //abstract public string InteractableName { get;  set;  }
    //abstract public string InteractableDescription { get; set; }
    //abstract public bool CanInteract { get; set; }
    //abstract public Flowchart ObjectFlowChart { get; set; }
    //abstract public int ItemCount { get; set; }
    //######################################################################
    abstract public UnityAction ItemTakenListener { get; set; }
    abstract public UnityAction ItemNotTakenListener { get; set; }
}
