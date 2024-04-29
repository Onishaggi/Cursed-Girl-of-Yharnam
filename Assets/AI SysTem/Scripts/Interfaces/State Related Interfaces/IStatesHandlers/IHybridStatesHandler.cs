
using System.Collections.Generic;


public interface IHybridStatesHandler
{
    public List<HybridState> States { get; set; }
    public List<float> ActivationDistance { get; set; }
}
