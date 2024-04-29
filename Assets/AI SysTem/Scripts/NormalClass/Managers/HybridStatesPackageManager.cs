using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HybridStatesPackageManager : IHybridStatesHandler
{
    private HybridStatesPackage _statesPackage;


    private UniEvent _notifier;
    private int _currentStateID;


    public HybridStatesPackageManager(HybridStatesPackage _statesPackage)
    {
        _notifier = new UniEvent();
        this._statesPackage = _statesPackage;
        _currentStateID = 0;
        _statesPackage.States[_currentStateID].IsStateActive = true;

    }

    public UniEvent StateChangeNotify { get { return _notifier; } set { _notifier = value; } }

    public List<HybridState> States { get { return _statesPackage.States; } set { _statesPackage.States = value; } }


    public List<float> ActivationDistance { get { return _statesPackage.ActivationDistance; } set { _statesPackage.ActivationDistance = value; } }

    public IHybridState GetCurrentState(Transform self, Transform target)
    {
        if (target != null)
        {
            if (_currentStateID != States.Count - 1 && Vector3.SqrMagnitude(target.transform.position - self.position) <= ActivationDistance[_currentStateID] * ActivationDistance[_currentStateID])
            {
                _statesPackage.States[_currentStateID].IsStateActive = false;
                _currentStateID++;
                _statesPackage.States[_currentStateID].IsStateActive = true;
                StateChangeNotify.Notify();
            }
            if (_currentStateID != 0 && Vector3.SqrMagnitude(target.transform.position - self.position) > ActivationDistance[_currentStateID - 1] * ActivationDistance[_currentStateID - 1])
            {
                _statesPackage.States[_currentStateID].IsStateActive = false;
                _currentStateID--;
                _statesPackage.States[_currentStateID].IsStateActive = true;
                StateChangeNotify.Notify();
            }
        }
        
            //Debug.Log(States[_currentStateID].StateName);
            //Debug.Log(_currentStateID);
        //here might cause problems in future keep an eye
        return States[_currentStateID];
        

    }
}
