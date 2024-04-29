using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityStatesPackageManager :IUtilityStatesHandler
{
    private UtilityStatesPackage _statesPackage;



    private int _currentStateID;


    public UtilityStatesPackageManager(UtilityStatesPackage _statesPackage)
    {
        this._statesPackage = _statesPackage;
        _currentStateID = 0;

    }

    public List<IUtilityState> States { get { return _statesPackage.States; } set { _statesPackage.States = value; } }


    public List<float> ActivationDistance { get { return _statesPackage.ActivationDistance; } set { _statesPackage.ActivationDistance = value; } }

    public IUtilityState GetCurrentState(Transform self, Transform target)
    {
        if (_currentStateID != States.Count - 1 && Vector3.SqrMagnitude(target.transform.position - self.position) <= ActivationDistance[_currentStateID] * ActivationDistance[_currentStateID])
        {

            _currentStateID++;
        }
        if (_currentStateID != 0 && Vector3.SqrMagnitude(target.transform.position - self.position) > ActivationDistance[_currentStateID + 1] * ActivationDistance[_currentStateID + 1])
        {
            _currentStateID--;
        }
        return States[_currentStateID];

    }
}
