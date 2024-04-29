using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class InteractablePickableObjectData : AInteractableObjectData
{
    abstract public int ItemCount {  get; set; }
    //abstract public UnityAction ItemTakenEvent { get; set; }
    //abstract public UnityAction ItemNotTakenEvent { get; set; }
    
}
