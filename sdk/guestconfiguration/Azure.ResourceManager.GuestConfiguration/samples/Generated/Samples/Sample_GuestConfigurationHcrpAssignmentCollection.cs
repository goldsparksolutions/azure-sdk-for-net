// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.GuestConfiguration;
using Azure.ResourceManager.GuestConfiguration.Models;

namespace Azure.ResourceManager.GuestConfiguration.Samples
{
    public partial class Sample_GuestConfigurationHcrpAssignmentCollection
    {
        // Create or update guest configuration assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2022-01-25/examples/createOrUpdateGuestConfigurationHCRPAssignment.json
            // this example is just showing the usage of "GuestConfigurationHCRPAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationHcrpAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.HybridCompute/machines/{2}", subscriptionId, resourceGroupName, machineName));
            GuestConfigurationHcrpAssignmentCollection collection = client.GetGuestConfigurationHcrpAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "NotInstalledApplicationForWindows";
            GuestConfigurationAssignmentData data = new GuestConfigurationAssignmentData()
            {
                Properties = new GuestConfigurationAssignmentProperties()
                {
                    GuestConfiguration = new GuestConfigurationNavigation()
                    {
                        Name = "NotInstalledApplicationForWindows",
                        Version = "1.*",
                        ContentUri = new Uri("https://thisisfake/pacakge"),
                        ContentHash = "123contenthash",
                        AssignmentType = GuestConfigurationAssignmentType.ApplyAndAutoCorrect,
                        ConfigurationParameters =
{
new GuestConfigurationParameter()
{
Name = "[InstalledApplication]NotInstalledApplicationResource1;Name",
Value = "NotePad,sql",
}
},
                    },
                    Context = "Azure policy",
                },
                Name = "NotInstalledApplicationForWindows",
                Location = new AzureLocation("westcentralus"),
            };
            ArmOperation<GuestConfigurationHcrpAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, guestConfigurationAssignmentName, data);
            GuestConfigurationHcrpAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a guest configuration assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2022-01-25/examples/getGuestConfigurationHCRPAssignment.json
            // this example is just showing the usage of "GuestConfigurationHCRPAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationHcrpAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.HybridCompute/machines/{2}", subscriptionId, resourceGroupName, machineName));
            GuestConfigurationHcrpAssignmentCollection collection = client.GetGuestConfigurationHcrpAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            GuestConfigurationHcrpAssignmentResource result = await collection.GetAsync(guestConfigurationAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a guest configuration assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2022-01-25/examples/getGuestConfigurationHCRPAssignment.json
            // this example is just showing the usage of "GuestConfigurationHCRPAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationHcrpAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.HybridCompute/machines/{2}", subscriptionId, resourceGroupName, machineName));
            GuestConfigurationHcrpAssignmentCollection collection = client.GetGuestConfigurationHcrpAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            bool result = await collection.ExistsAsync(guestConfigurationAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a guest configuration assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2022-01-25/examples/getGuestConfigurationHCRPAssignment.json
            // this example is just showing the usage of "GuestConfigurationHCRPAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationHcrpAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.HybridCompute/machines/{2}", subscriptionId, resourceGroupName, machineName));
            GuestConfigurationHcrpAssignmentCollection collection = client.GetGuestConfigurationHcrpAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            NullableResponse<GuestConfigurationHcrpAssignmentResource> response = await collection.GetIfExistsAsync(guestConfigurationAssignmentName);
            GuestConfigurationHcrpAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GuestConfigurationAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List all guest configuration assignments for a virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllGuestConfigurationAssignmentsForAVirtualMachine()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2022-01-25/examples/listGuestConfigurationHCRPAssignments.json
            // this example is just showing the usage of "GuestConfigurationHCRPAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationHcrpAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.HybridCompute/machines/{2}", subscriptionId, resourceGroupName, machineName));
            GuestConfigurationHcrpAssignmentCollection collection = client.GetGuestConfigurationHcrpAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (GuestConfigurationHcrpAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GuestConfigurationAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
