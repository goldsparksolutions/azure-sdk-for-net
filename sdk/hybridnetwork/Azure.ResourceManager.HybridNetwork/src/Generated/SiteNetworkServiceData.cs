// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the SiteNetworkService data model.
    /// Site network service resource.
    /// </summary>
    public partial class SiteNetworkServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SiteNetworkServiceData. </summary>
        /// <param name="location"> The location. </param>
        public SiteNetworkServiceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SiteNetworkServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Site network service properties. </param>
        /// <param name="identity"> The managed identity of the Site network service, if configured. </param>
        /// <param name="sku"> Sku of the site network service. </param>
        internal SiteNetworkServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SiteNetworkServicePropertiesFormat properties, ManagedServiceIdentity identity, HybridNetworkSku sku) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Identity = identity;
            Sku = sku;
        }

        /// <summary> Site network service properties. </summary>
        public SiteNetworkServicePropertiesFormat Properties { get; set; }
        /// <summary> The managed identity of the Site network service, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Sku of the site network service. </summary>
        public HybridNetworkSku Sku { get; set; }
    }
}
