using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName = "InteractionSystem/PickableObjects/ IPO Data")]
public class ScriptableO_IPO_Data : InteractablePickableObjectData
{

    [SerializeField] private int _itemCount;
    [SerializeField] private string _blockName;
    [SerializeField] private string _interacctableName;
    [SerializeField] private string _interacctableDiscription;
    [SerializeField] private bool _canInteract;
    private Flowchart _objectFlowChart;

    public override int ItemCount { get { return _itemCount; } set { _itemCount = value; } }
    //public override UnityAction ItemTakenEvent { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    //public override UnityAction ItemNotTakenEvent { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public override string InteractableName { get { return _interacctableName; } set { _interacctableName = value; } }
    public override string InteractableDescription { get { return _interacctableDiscription; } set { _interacctableDiscription = value; } }
    public override bool CanInteract { get { return _canInteract; } set { _canInteract = value; } }
    public override Flowchart ObjectFlowChart { get { return _objectFlowChart; } set { _objectFlowChart = value; } }
    public override string BlockName { get => _blockName; set => _blockName = value; }
}
