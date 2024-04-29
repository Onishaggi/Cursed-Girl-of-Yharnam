using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IQR_mono : AInteractableQuestRelatedObject
{

    [SerializeField] private InteractableQuestRelatedData _objectData;
    [SerializeField] private InteractableQuestRelatedBehavioursPackage _interactableQuestObjectPackage;
    private Flowchart _flowChart;
    private InteractableQuestRelatedData _mQuestObjectData;
    private InteractableQuestRelatedBehavioursPackage _minteractableQuestObjectPackage;
    private IQR_PackageManager _objectPackageManager;


    public IQR_PackageManager IPO_PackageManager { get { return _objectPackageManager; } set { _objectPackageManager = value; } }
    public override InteractableQuestRelatedData QuestObjectData { get { return _mQuestObjectData; } set { _mQuestObjectData = value; } }
    public override InteractableQuestRelatedBehavioursPackage InteractableQuestRelatedBehaviourPackage { get { return _minteractableQuestObjectPackage; } set { _minteractableQuestObjectPackage = value; } }
    public override UnityAction ItemTakenListener { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public override UnityAction ItemNotTakenListener { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public override Flowchart MFlowchart { get => _flowChart; set => _flowChart = value; }

    private void Awake()
    {
        
        _mQuestObjectData = _objectData;
        _minteractableQuestObjectPackage = _interactableQuestObjectPackage;
        _objectPackageManager = new IQR_PackageManager(this);
        
    }
    void Start()
    {
        _flowChart = ServiceLocator.Instance.GetService<GameManager>().Flowchart;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
