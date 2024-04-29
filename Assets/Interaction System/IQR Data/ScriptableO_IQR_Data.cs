using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InteractionSystem/QuestObjects/ IQR Data")]
public class ScriptableO_IQR_Data : InteractableQuestRelatedData
{

    [SerializeField] private bool _activateRequirementsCompleted;
    [SerializeField] private string _blockName;
    [SerializeField] private string _interacctableName;
    [SerializeField] private string _interacctableDiscription;
    [SerializeField] private bool _canInteract;
    private Flowchart _objectFlowChart;


    public override string InteractableName { get { return _interacctableName; } set { _interacctableName = value; } }
    public override string InteractableDescription { get { return _interacctableDiscription; } set { _interacctableDiscription = value; } }
    public override bool CanInteract { get { return _canInteract; } set { _canInteract = value; } }
    public override Flowchart ObjectFlowChart { get { return _objectFlowChart; } set { _objectFlowChart = value; } }
    public override bool ActivateRequirementsCompleted { get { return _activateRequirementsCompleted; } set { _activateRequirementsCompleted = value; } }
    public override string BlockName { get => _blockName; set => _blockName = value; }
}
