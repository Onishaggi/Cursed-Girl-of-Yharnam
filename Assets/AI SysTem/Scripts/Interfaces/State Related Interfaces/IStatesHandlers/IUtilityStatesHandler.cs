
using System.Collections.Generic;
public interface IUtilityStatesHandler
{
    public List<IUtilityState> States { get; set; }
    public List<float> ActivationDistance { get; set; }
}
