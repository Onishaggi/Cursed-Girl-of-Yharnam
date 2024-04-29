

using System.Collections.Generic;
using UnityEngine;

public interface IStatesHandler
{
    public List<IState> States { get; set;}
    public List<float> ActivationDistance { get; set; }
}
