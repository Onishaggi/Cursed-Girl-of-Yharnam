
using System.Collections.Generic;


public interface IAggressorStateHandler
{
    public List<IAggressorState> States { get; set; }
    public List<float> ActivationDistance { get; set; }
}
