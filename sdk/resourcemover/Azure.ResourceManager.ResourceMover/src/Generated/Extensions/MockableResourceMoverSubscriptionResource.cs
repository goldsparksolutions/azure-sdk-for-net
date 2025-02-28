// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableResourceMoverSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _moverResourceSetMoveCollectionsClientDiagnostics;
        private MoveCollectionsRestOperations _moverResourceSetMoveCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableResourceMoverSubscriptionResource"/> class for mocking. </summary>
        protected MockableResourceMoverSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourceMoverSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourceMoverSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MoverResourceSetMoveCollectionsClientDiagnostics => _moverResourceSetMoveCollectionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceMover", MoverResourceSetResource.ResourceType.Namespace, Diagnostics);
        private MoveCollectionsRestOperations MoverResourceSetMoveCollectionsRestClient => _moverResourceSetMoveCollectionsRestClient ??= new MoveCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MoverResourceSetResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get all the Move Collections in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Migrate/moveCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_ListMoveCollectionsBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MoverResourceSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MoverResourceSetResource> GetMoverResourceSetsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MoverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MoverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MoverResourceSetResource(Client, MoverResourceSetData.DeserializeMoverResourceSetData(e)), MoverResourceSetMoveCollectionsClientDiagnostics, Pipeline, "MockableResourceMoverSubscriptionResource.GetMoverResourceSets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the Move Collections in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Migrate/moveCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_ListMoveCollectionsBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MoverResourceSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MoverResourceSetResource> GetMoverResourceSets(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MoverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MoverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MoverResourceSetResource(Client, MoverResourceSetData.DeserializeMoverResourceSetData(e)), MoverResourceSetMoveCollectionsClientDiagnostics, Pipeline, "MockableResourceMoverSubscriptionResource.GetMoverResourceSets", "value", "nextLink", cancellationToken);
        }
    }
}
