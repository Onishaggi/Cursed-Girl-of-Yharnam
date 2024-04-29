using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.Rendering.DebugUI;

public class IPO_mono : AInteractablePickableObject
{
    [SerializeField] private InteractablePickableObjectData _itemData;
    [SerializeField] private InteractablePickableObjectBehavioursPackage _interactablePickableObjectPackage;
    private InteractablePickableObjectData _mitemData;
    private InteractablePickableObjectBehavioursPackage _minteractablePickableObjectPackage;
    private IPO_PackageManager _objectPackageManager;

    //private int _itemCount;
    //private string _interacctableName;
    //private string _interacctableDiscription;
    //private bool _canInteract;
    //private Flowchart _objectFlowChart;


    public IPO_PackageManager IPO_PackageManager { get { return _objectPackageManager; } set { _objectPackageManager = value; } }
    //public override string InteractableName { get { return _mitemData.InteractableName; } set { _mitemData.InteractableName = value; } }
    //public override string InteractableDescription { get { return _itemData.InteractableDescription; } set { _itemData.InteractableDescription = value; } }
    //public override bool CanInteract { get { return _mitemData.CanInteract; } set { _mitemData.CanInteract = value; } }
    //public override Flowchart ObjectFlowChart { get { return _mitemData.ObjectFlowChart; } set { _mitemData.ObjectFlowChart = value; } }
    //public override int ItemCount { get { { return _mitemData.ItemCount; } } set { _mitemData.ItemCount = value; } }
    public override UnityAction ItemTakenListener { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public override UnityAction ItemNotTakenListener { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public override InteractablePickableObjectData ItemData { get { return _mitemData; } set { _mitemData = value; } }
    public override InteractablePickableObjectBehavioursPackage InteractablePickableObjectBehaviourPackage { get { return _minteractablePickableObjectPackage; } set { _minteractablePickableObjectPackage = value; } }

    private void Awake()
    {
        _mitemData = _itemData;
        _minteractablePickableObjectPackage = _interactablePickableObjectPackage;
        _objectPackageManager= new IPO_PackageManager(this);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
