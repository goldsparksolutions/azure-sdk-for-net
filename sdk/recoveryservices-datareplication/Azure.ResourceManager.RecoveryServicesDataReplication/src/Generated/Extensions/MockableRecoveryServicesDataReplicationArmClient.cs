// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableRecoveryServicesDataReplicationArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableRecoveryServicesDataReplicationArmClient"/> class for mocking. </summary>
        protected MockableRecoveryServicesDataReplicationArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableRecoveryServicesDataReplicationArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableRecoveryServicesDataReplicationArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableRecoveryServicesDataReplicationArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationDraResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationDraResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationDraResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationDraResource" /> object. </returns>
        public virtual DataReplicationDraResource GetDataReplicationDraResource(ResourceIdentifier id)
        {
            DataReplicationDraResource.ValidateResourceId(id);
            return new DataReplicationDraResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationEmailConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationEmailConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationEmailConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationEmailConfigurationResource" /> object. </returns>
        public virtual DataReplicationEmailConfigurationResource GetDataReplicationEmailConfigurationResource(ResourceIdentifier id)
        {
            DataReplicationEmailConfigurationResource.ValidateResourceId(id);
            return new DataReplicationEmailConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationEventResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationEventResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationEventResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationEventResource" /> object. </returns>
        public virtual DataReplicationEventResource GetDataReplicationEventResource(ResourceIdentifier id)
        {
            DataReplicationEventResource.ValidateResourceId(id);
            return new DataReplicationEventResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationFabricResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationFabricResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationFabricResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationFabricResource" /> object. </returns>
        public virtual DataReplicationFabricResource GetDataReplicationFabricResource(ResourceIdentifier id)
        {
            DataReplicationFabricResource.ValidateResourceId(id);
            return new DataReplicationFabricResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationPolicyResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationPolicyResource" /> object. </returns>
        public virtual DataReplicationPolicyResource GetDataReplicationPolicyResource(ResourceIdentifier id)
        {
            DataReplicationPolicyResource.ValidateResourceId(id);
            return new DataReplicationPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationProtectedItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationProtectedItemResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationProtectedItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationProtectedItemResource" /> object. </returns>
        public virtual DataReplicationProtectedItemResource GetDataReplicationProtectedItemResource(ResourceIdentifier id)
        {
            DataReplicationProtectedItemResource.ValidateResourceId(id);
            return new DataReplicationProtectedItemResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationRecoveryPointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationRecoveryPointResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationRecoveryPointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationRecoveryPointResource" /> object. </returns>
        public virtual DataReplicationRecoveryPointResource GetDataReplicationRecoveryPointResource(ResourceIdentifier id)
        {
            DataReplicationRecoveryPointResource.ValidateResourceId(id);
            return new DataReplicationRecoveryPointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationReplicationExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationReplicationExtensionResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationReplicationExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationReplicationExtensionResource" /> object. </returns>
        public virtual DataReplicationReplicationExtensionResource GetDataReplicationReplicationExtensionResource(ResourceIdentifier id)
        {
            DataReplicationReplicationExtensionResource.ValidateResourceId(id);
            return new DataReplicationReplicationExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationVaultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationVaultResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationVaultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationVaultResource" /> object. </returns>
        public virtual DataReplicationVaultResource GetDataReplicationVaultResource(ResourceIdentifier id)
        {
            DataReplicationVaultResource.ValidateResourceId(id);
            return new DataReplicationVaultResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataReplicationWorkflowResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataReplicationWorkflowResource.CreateResourceIdentifier" /> to create a <see cref="DataReplicationWorkflowResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataReplicationWorkflowResource" /> object. </returns>
        public virtual DataReplicationWorkflowResource GetDataReplicationWorkflowResource(ResourceIdentifier id)
        {
            DataReplicationWorkflowResource.ValidateResourceId(id);
            return new DataReplicationWorkflowResource(Client, id);
        }
    }
}
