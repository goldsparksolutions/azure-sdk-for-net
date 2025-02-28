// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Contains Provisioning errors. </summary>
    public partial class VirtualNetworksPropertiesStatusProvisioningStatus
    {
        /// <summary> Initializes a new instance of VirtualNetworksPropertiesStatusProvisioningStatus. </summary>
        internal VirtualNetworksPropertiesStatusProvisioningStatus()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworksPropertiesStatusProvisioningStatus. </summary>
        /// <param name="error"></param>
        /// <param name="operationId"></param>
        /// <param name="phase"> Phase represents the current phase of cluster actuation. E.g. Pending, Running, Terminating, Failed etc. </param>
        /// <param name="status"></param>
        internal VirtualNetworksPropertiesStatusProvisioningStatus(VirtualNetworksPropertiesStatusProvisioningStatusError error, string operationId, string phase, string status)
        {
            Error = error;
            OperationId = operationId;
            Phase = phase;
            Status = status;
        }

        /// <summary> Gets the error. </summary>
        public VirtualNetworksPropertiesStatusProvisioningStatusError Error { get; }
        /// <summary> Gets the operation id. </summary>
        public string OperationId { get; }
        /// <summary> Phase represents the current phase of cluster actuation. E.g. Pending, Running, Terminating, Failed etc. </summary>
        public string Phase { get; }
        /// <summary> Gets the status. </summary>
        public string Status { get; }
    }
}
