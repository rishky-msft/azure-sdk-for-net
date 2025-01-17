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
using Azure.ResourceManager.HardwareSecurityModules;
using Azure.ResourceManager.HardwareSecurityModules.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HardwareSecurityModules.Samples
{
    public partial class Sample_CloudHsmClusterResource
    {
        // CloudHsmCluster_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CloudHsmClusterUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2022-08-31-preview/examples/CloudHsmCluster_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterResource created on azure
            // for more information of creating CloudHsmClusterResource, please refer to the document of CloudHsmClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            ResourceIdentifier cloudHsmClusterResourceId = CloudHsmClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName);
            CloudHsmClusterResource cloudHsmCluster = client.GetCloudHsmClusterResource(cloudHsmClusterResourceId);

            // invoke the operation
            CloudHsmClusterPatch patch = new CloudHsmClusterPatch()
            {
                Tags =
{
["Dept"] = "hsm",
["Environment"] = "dogfood",
["Slice"] = "A",
},
            };
            ArmOperation<CloudHsmClusterResource> lro = await cloudHsmCluster.UpdateAsync(WaitUntil.Completed, patch);
            CloudHsmClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudHsmClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CloudHsmCluster_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CloudHsmClusterGetMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2022-08-31-preview/examples/CloudHsmCluster_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterResource created on azure
            // for more information of creating CloudHsmClusterResource, please refer to the document of CloudHsmClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            ResourceIdentifier cloudHsmClusterResourceId = CloudHsmClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName);
            CloudHsmClusterResource cloudHsmCluster = client.GetCloudHsmClusterResource(cloudHsmClusterResourceId);

            // invoke the operation
            CloudHsmClusterResource result = await cloudHsmCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudHsmClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CloudHsmCluster_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CloudHsmClusterDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2022-08-31-preview/examples/CloudHsmCluster_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterResource created on azure
            // for more information of creating CloudHsmClusterResource, please refer to the document of CloudHsmClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            ResourceIdentifier cloudHsmClusterResourceId = CloudHsmClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName);
            CloudHsmClusterResource cloudHsmCluster = client.GetCloudHsmClusterResource(cloudHsmClusterResourceId);

            // invoke the operation
            await cloudHsmCluster.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CloudHsmCluster_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCloudHsmClusters_CloudHsmClusterListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2022-08-31-preview/examples/CloudHsmCluster_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusters_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (CloudHsmClusterResource item in subscriptionResource.GetCloudHsmClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudHsmClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CloudHsmClusterPrivateLinkResources_ListByResource_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCloudHsmClusterPrivateLinkResources_CloudHsmClusterPrivateLinkResourcesListByResourceMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2022-08-31-preview/examples/CloudHsmClusterPrivateLinkResource_ListByCloudHsmCluster_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusterPrivateLinkResources_ListByCloudHsmCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterResource created on azure
            // for more information of creating CloudHsmClusterResource, please refer to the document of CloudHsmClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            ResourceIdentifier cloudHsmClusterResourceId = CloudHsmClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName);
            CloudHsmClusterResource cloudHsmCluster = client.GetCloudHsmClusterResource(cloudHsmClusterResourceId);

            // invoke the operation and iterate over the result
            await foreach (HardwareSecurityModulesPrivateLinkData item in cloudHsmCluster.GetCloudHsmClusterPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
