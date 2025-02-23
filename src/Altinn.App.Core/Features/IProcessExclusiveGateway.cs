using Altinn.App.Core.Internal.Process.Elements;
using Altinn.Platform.Storage.Interface.Models;

namespace Altinn.App.Core.Features;

/// <summary>
/// Interface for defining custom decision logic for exclusive gateways 
/// </summary>
public interface IProcessExclusiveGateway
{
    /// <summary>
    /// 
    /// </summary>
    string GatewayId { get; }

    /// <summary>
    /// Filter out non viable flows from a gateway with id as defined in <see cref="GatewayId"/>
    /// </summary>
    /// <param name="outgoingFlows">Complete list of defined flows out of gateway</param>
    /// <param name="instance">Instance where process is about to move next</param>
    /// <returns></returns>
    public Task<List<SequenceFlow>> FilterAsync(List<SequenceFlow> outgoingFlows, Instance instance);
}
